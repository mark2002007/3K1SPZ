using System.Collections.Generic;
using Task_3;
using Xunit;

namespace Task_3_Tests
{
    public class FileUtilsTests
    {
        private string path = @"..\..\..\text.txt";

        [Theory, MemberData(nameof(Data))]
        public void ReadTest_ReturnsString_Equal(List<int> numList, string expected)
        {
            //Arrange
            FileUtils fileUtils = new FileUtils(new StubDigitUtils(numList));
            //Act
            var actual = fileUtils.Read();
            //Assert
            Assert.Equal(actual, expected);
        }

        public static IEnumerable<object[]> Data => 
            new List<object[]>
            {
                new object[] {new List<int> {1, 2, 3}, "1, 2, 3" },
                new object[] {new List<int> {}, ""},
                new object[]
                {
                    new List<int> {int.MaxValue, int.MinValue, int.MaxValue - 1, int.MinValue + 1, 0},
                    $"{int.MaxValue}, {int.MinValue}, {int.MaxValue - 1}, {int.MinValue + 1}, {0}"
                }
            };

        //Boundary Value
    }
}