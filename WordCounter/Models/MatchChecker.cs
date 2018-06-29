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

        public string RemoveSpacesandCharactersFromSingleWord(string inputOne)
        {
            char[] charsToTrim = { ',', '{', ' ', '~', '`', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '+', '='};        
            string singleInputWithoutCharacters = inputOne.Trim(charsToTrim);
            return singleInputWithoutCharacters;
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





        //public string[] RemoveCharactersFromStringWords(string inputTwo)
        //{
        //    string lowerCaseInputTwo = inputTwo.ToLower();
        //    string[] inputTwoArray = lowerCaseInputTwo.Split(' ');
        //    char[] charsToTrim = { ',', '{', '~', '`', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '+', '=' };
        //    string wordsInputWithoutCharacters = inputTwoArray.Replace(charsToTrim, 'd');
        //    return wordsInputWithoutCharacters;
        //}

        public int Final(string inputOne, string inputTwo)
        {

            var arr = inputTwo.Split(new char[] { ' ', '.', ',', ';', ':', '?', '!' });
            var count = Array.FindAll(arr, s => s.Equals(inputOne.Trim())).Length;
            return count;
        
        }
    }
}
