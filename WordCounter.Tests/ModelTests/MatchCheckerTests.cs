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
            string userInput = "Dog!";
            MatchWord testMatchWord = new MatchWord();
            Assert.AreEqual("Dog!", testMatchWord.GetSingleWord(userInput));
        }

        [TestMethod]
        public void GetStringOfWords_StoreInputInString_MultipleInputs()
        {
            string userInput = "Is your dog happ$y";
            MatchWord testMatchWord = new MatchWord();
            Assert.AreEqual("Is your dog happ$y", testMatchWord.GetSingleWord(userInput));
        }

        [TestMethod]
        public void CheckSingleWordForSpaces_TrueIfSpaces_bool()
        {
            string userInput = "Dog! ";
            MatchWord testMatchWord = new MatchWord();
            Assert.AreEqual(true, testMatchWord.CheckSingleWordForSpaces(userInput));
        }

        [TestMethod]
        public void RemoveSpacesandCharactersFromSingleWord_TrueIfSpaces_int()
        {
            string userInput = "Dog! ";
            MatchWord testMatchWord = new MatchWord();
            Assert.AreEqual("Dog", testMatchWord.RemoveSpacesandCharactersFromSingleWord(userInput));
        }

        [TestMethod]
        public void ConvertSingleWordToLowerCase_ReturnLowercase_string()
        {
            string userInput = "Dog";
            MatchWord testMatchWord = new MatchWord();
            Assert.AreEqual("dog", testMatchWord.ConvertSingleWordToLowerCase(userInput));
        }

        [TestMethod]
        public void ConvertStringOfWordsToLowerCase_ReturnLowercase_string()
        {
            string userInput = "Is Your Dog a Happy Dog";
            MatchWord testMatchWord = new MatchWord();
            Assert.AreEqual("is your dog a happy dog", testMatchWord.ConvertStringOfWordsToLowerCase(userInput));
        }

        //[TestMethod]
        //public void RemoveCharactersFromStringWords_TrueIfSpaces_int()
        //{
        //    string userInput = "Is your dog happ$y";
        //    MatchWord testMatchWord = new MatchWord();
        //    Assert.AreEqual("Is your dog happy", testMatchWord.RemoveCharactersFromStringWords(userInput));
        //}

        [TestMethod]
        public void Final_NumberOfInstances_int()
        {
            string userWord = "dog";
            string userWords = "Is your dog a happy dog";
            MatchWord testMatchWord = new MatchWord();
            Assert.AreEqual(2, testMatchWord.Final(userWord, userWords));
        }
    }
}
