using System.Collections.Generic;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Counter;

namespace WordCounter.Tests.ModelTests
{
    [TestClass]
    public class MatchWordTests
    {
        [TestMethod]
        public void GetSingleWord_StoreInputInString_SingleInput()
        {
            string userInput = "Dog!";
            MatchWord testCounter = new MatchWord();
            Assert.AreEqual("Dog!", testCounter.GetSingleWord(userInput));
        }
    }
}
