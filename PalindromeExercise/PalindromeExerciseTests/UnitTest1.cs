using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("noon", true)]
        [InlineData("kayak", true)]
        [InlineData("steep", false)]
        [InlineData("computer", false)]
        [InlineData("yeti", false)]
        [InlineData("", false)]
        [InlineData(null, false)]

        public void Test1(string word, bool expected)
        {
            //Arrange
            WordSmith challenger = new WordSmith();

            //Act
            var actual = challenger.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
