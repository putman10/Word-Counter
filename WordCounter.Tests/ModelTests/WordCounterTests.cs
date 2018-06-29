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
    }
}
