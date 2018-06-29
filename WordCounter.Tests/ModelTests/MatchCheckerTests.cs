using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using WordCounter;

namespace WordCounter.Tests
{
    [TestClass]
    public class MatchWordTests
    {
        [TestMethod]
        public void GetSingleWord_StoreInputInString_SingleInput()
        {
            string userInput = "Dog";
            RepeatCounter testRepeatCounter = new RepeatCounter();
            Assert.AreEqual("Dog", testRepeatCounter.RemoveSpacesandCharactersFromSingleWord(userInput));
        }

        [TestMethod]
        public void GetStringOfWords_StoreInputInString_MultipleInputs()
        {
            string userInput = "Is your dog happy";
            RepeatCounter testRepeatCounter = new RepeatCounter();
            Assert.AreEqual("Is your dog happy", testRepeatCounter.RemoveCharactersFromStringWords(userInput));
        }

        [TestMethod]
        public void RemoveSpacesandCharactersFromSingleWord_TrueIfSpaces_int()
        {
            string userInput = "Dog! ";
            RepeatCounter testRepeatCounter = new RepeatCounter();
            Assert.AreEqual("Dog", testRepeatCounter.RemoveSpacesandCharactersFromSingleWord(userInput));
        }

        [TestMethod]
        public void RemoveCharactersFromStringWords_TrueIfSpaces_int()
        {
            string userInput = "Is your dog happ$y";
            RepeatCounter testRepeatCounter = new RepeatCounter();
            Assert.AreEqual("Is your dog happy", testRepeatCounter.RemoveCharactersFromStringWords(userInput));
        }

        [TestMethod]
        public void ConvertSingleWordToLowerCase_ReturnLowercase_string()
        {
            string userInput = "Dog";
            RepeatCounter testRepeatCounter = new RepeatCounter();
            Assert.AreEqual("dog", testRepeatCounter.ConvertSingleWordToLowerCase(userInput));
        }

        [TestMethod]
        public void ConvertStringOfWordsToLowerCase_ReturnLowercase_string()
        {
            string userInput = "Is Your Dog Happy";
            RepeatCounter testRepeatCounter = new RepeatCounter();
            Assert.AreEqual("is your dog happy", testRepeatCounter.ConvertStringOfWordsToLowerCase(userInput));
        }

        [TestMethod]
        public void Final_NumberOfInstances_int()
        {
            string userWord = "dog";
            string userWords = "is your dog happy";
            RepeatCounter testRepeatCounter = new RepeatCounter();
            Assert.AreEqual(1, testRepeatCounter.Final(userWord, userWords));
        }
    }
}
