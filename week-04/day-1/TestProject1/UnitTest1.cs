using System;
using System.Collections.Generic;
using Testing;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void PalindromeWithNullInput_ThrowsException()
        {
            Assert.Throws<NullReferenceException>(() => Program.FindPalindromes(null, 1));
        }

        [Theory]
        [InlineData("racecar", 7, new string[] { "racecar" })]
        [InlineData("otto", 4, new string[] { "otto" })]
        public void PalindromeWithValidInput_ReturnsResult(string input, int minLength, string[] expected)
        {
            //Act
            string[] actual = Program.FindPalindromes(input, minLength);

            //Assert
            Assert.Equal(expected, actual);
        }

        /*[Fact]
        public void PalindromeWithValidInput_ReturnsResult()
        {
            //Arrange
            string input = "racecar";
            int minLength = 7;
            List<string> expected = new List<string> { "racecar" };

            //Act
            List<string> actual = Program.FindPalindromes(input, minLength);

            //Assert
            Assert.Equal(expected, actual);
        }*/
    }
}