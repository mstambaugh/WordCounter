using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCount
    {
        [TestMethod]
        public void IsValidEntry_SentenceLongerThanWord_True()
        {
            // Arrange
            string inputWord = "dog";
            string inputSentence = "dogs are cute";
            // Act
            bool result = RepeatCounter.IsValidEntry(inputWord, inputSentence);
            // Assert
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void CheckForMatchInSentence_WordEqualsArrayWord_Integer()
        {
            // Arrange
            string inputWord = "dog";
            string inputSentence = "blue is a dog";
            // Act
            int result = RepeatCounter.CheckForMatchInSentence(inputWord, inputSentence);
            // Assert
            Assert.AreEqual(9, result);
        }
    }
}