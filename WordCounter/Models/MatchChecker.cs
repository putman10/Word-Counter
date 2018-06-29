using System;
using System.Collections.Generic;
using System.Linq;
using WordCounterMain;

namespace WordCounter
{
    public class MatchWord
    {

        public string RemoveSpacesandCharactersFromSingleWord(string inputOne)
        {
            char[] charsToTrim = { ',', '{', ' ', '~', '`', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '+', '=' };
            string singleInputWithoutCharacters = inputOne.Trim(charsToTrim);
            return singleInputWithoutCharacters;
        }

        public string RemoveCharactersFromStringWords(string inputTwo)
        {
            string[] chars = new string[] { ",", ".", "/", "!", "@", "#", "$", "%", "^", "&", "*", "'", "\"", ";", "_", "(", ")", ":", "|", "[", "]" };

            for (int i = 0; i < chars.Length; i++)
            {
                if (inputTwo.Contains(chars[i]))
                {
                    inputTwo = inputTwo.Replace(chars[i], "");
                }
            }
            return inputTwo;
        }

        public string ConvertSingleWordToLowerCase(string inputOne)
        {
            string lowerCaseInputOne = inputOne.ToLowerInvariant();
            return lowerCaseInputOne;
        }

        public string ConvertStringOfWordsToLowerCase(string inputTwo)
        {
            string lowerCaseInputTwo = inputTwo.ToLowerInvariant();
            return lowerCaseInputTwo;
        }

        public int Final(string inputOne, string inputTwo)
        {

            var arr = inputTwo.Split(new char[] { ' ', '.', ',', ';', ':', '?', '!' });
            var count = Array.FindAll(arr, s => s.Equals(inputOne.Trim())).Length;
            return count;

        }
    }
}