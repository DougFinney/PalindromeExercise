using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("palindrome", false)]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("Racecar", true)]
        [InlineData("kayak", true)]
        [InlineData("madam", true)]
        [InlineData("Kayak", true)]
        [InlineData("kaYak", true)]
        [InlineData("Jeremy", false)]
        [InlineData("tenet", true)]
        public void PalidromeTester(string word, bool expected)
        {
            //Arrange
            var tester = new WordSmith();

            //Act
            var actual = tester.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
