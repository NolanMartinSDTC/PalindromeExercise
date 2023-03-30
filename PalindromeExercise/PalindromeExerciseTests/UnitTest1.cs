using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("car", false)]
        public void IsAPalindrome(string word, bool isPalindrome)
        {
            // Arrange

            WordSmith palindrome = new WordSmith();

            // Act

            var actual = palindrome.IsAPalindrome(word);


            // Assert

            Assert.Equal(isPalindrome, actual);

        }
    }
}
