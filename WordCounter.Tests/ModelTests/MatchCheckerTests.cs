using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }
}
