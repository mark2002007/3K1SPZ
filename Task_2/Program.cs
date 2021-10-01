using System;
using System.Collections.Generic;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks.Dataflow;

namespace _3K1SPZT1
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public int id_role { get; set; }
        public string role_name {  get; set; }

        public string FullInfo => $"{name}\t({role_name})";
    }
    public class Role
    {
        public int id { get; set; }
        public string role { get; set; }
    }
    public class DAL
    {
        public List<User> GetAllUsers()
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("_3K1SPZT2_DB")))
            {
                return connection.Query<User>($"dbo.SelectAllUsers").ToList();
            }
        }

        public void AddUser(string name, int id_role)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("_3K1SPZT2_DB")))
            {
                connection.Execute("dbo.InsertUser @name, @id_role", new { name = name, id_role= id_role });
            }
        }

        public void AddRole(string name)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("_3K1SPZT2_DB")))
            {
                connection.Execute("dbo.InsertRole @name", new {name = name});
            }
        }

        public void DeleteUserByName(string name)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("_3K1SPZT2_DB")))
            {
                connection.Execute("dbo.DeleteUserByName @name", new {name = name});
            }
        }

        public void ChangeRole(string name, int new_role_id)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("_3K1SPZT2_DB")))
            {
                connection.Execute("dbo.SetRoleNameByName @name, @new_role_id", new { name = name, new_role_id = new_role_id });
            }
        }

    }

    public static class Helper
    {
        public static string CnnVal(string name) => ConfigurationManager.ConnectionStrings[name].ConnectionString;
    }
    static class Program
    {
        private static List<User> users = new();
        static void Main(string[] args)
        {
            DAL db = new DAL();
            //CREATE
            db.AddRole("Developer");
            db.AddRole("DevOps");
            db.AddRole("UX Designer");

            db.AddUser("Sophia", 1);
            db.AddUser("Quentin", 1);
            db.AddUser("Daniel", 2);
            db.AddUser("Miya", 2);
            db.AddUser("Jim", 3);
            db.AddUser("Tyrese", 3);

            //UPDATE
            db.ChangeRole("Quentin", 2); //Quentin -[ROLE_CHANGE]> DevOps
            db.ChangeRole("Daniel", 1); //Daniel -[ROLE_CHANGE]> Developer

            //READ
            users = db.GetAllUsers();
            foreach (var u in users) Console.WriteLine(u.FullInfo);

            //DELETE
            db.DeleteUserByName("Quentin"); // Delete Quentin
        }
    }
}