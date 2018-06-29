using System;
using System.Collections.Generic;
using System.Linq;
using WordCounterMain;

namespace WordCounter
{
    public class MatchWord
    {
        public string GetSingleWord(string inputOne)
        {
            string singleInput = inputOne;
            return singleInput;
        }

        public string GetStringOfWords(string inputTwo)
        {
            string wordsInput = inputTwo;
            return wordsInput;
        }

        public bool CheckSingleWordForSpaces(string inputOne)
        {
            bool wordHasSpace = inputOne.Contains(" ");
            return wordHasSpace;
        }

        public string CheckSingleWordForSpecCharacters(string inputOne)
        {
            char[] charsToTrim = { ',', '{', '~', '`', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '+', '='};        
            string singleInputWithoutCharacters = inputOne.Trim(charsToTrim);

            return singleInputWithoutCharacters;
        }
    }
}
