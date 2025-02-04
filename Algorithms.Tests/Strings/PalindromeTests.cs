﻿using Algorithms.Strings;
using NUnit.Framework;

namespace Algorithms.Tests.Strings
{
    public class PalindromeTests
    {
        [Test]
        [TestCase("Anna")]
        [TestCase("A Santa at Nasa")]
        public void TextIsPalindrome_TrueExpected(string text)
        {
            // Arrange
            // Act
            var isPalindrome = Palindrome.IsStringPalindrome(text);

            // Assert
            Assert.True(isPalindrome);
        }

        [Test]
        [TestCase("hallo")]
        [TestCase("Once upon a time")]
        public void TextNotPalindrome_FalseExpected(string text)
        {
            // Arrange
            // Act
            var isPalindrome = Palindrome.IsStringPalindrome(text);

            // Assert
            Assert.False(isPalindrome);
        }
    }
}
