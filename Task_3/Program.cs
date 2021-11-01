using System.IO;
using System.Linq;
using System.Collections.Generic;
namespace Task_3
{
    public interface IDigitUtils
    {
        public List<int> getNumbers(string path);
    }

    public class FileUtils
    {
        private IDigitUtils digitalUtils;
        public FileUtils(IDigitUtils digitUtils)
        {
            digitalUtils = digitUtils;
        }
        public String Read(string path = "") => String.Join(", ",digitalUtils.getNumbers(path));
    }

    public class DigitUtils : IDigitUtils
    {
        public List<int> getNumbers(string path) => 
            File.ReadAllText(path)
                .Split(' ')
                .Select(s => Int32.Parse(s))
                .ToList();
    }

    public class StubDigitUtils : IDigitUtils
    {
        private List<int> numbers;
        public StubDigitUtils(List<int> nums  = null)
        {
            numbers = nums;
        }
        public List<int> getNumbers(string path) => numbers;
    }

    class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\..\text.txt";
            //FileUtils
            FileUtils fileUtils = new FileUtils(new DigitUtils());
            foreach (var num in fileUtils.Read(path))
                Console.WriteLine(num);
        }
    }
}
