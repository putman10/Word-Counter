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

        //public bool CheckSingleWordForSpecCharacters(string inputOne)
        //{
        //    char[] charsToTrim = { ',', '{', '~', '`', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '+', '='};        

        //    foreach(char character in charsToTrim)
        //    {
        //        bool wordHasCharacter = inputOne.Contains(character);
        //        return true;
        //    }
        //}

        public string RemoveSpacesandCharactersFromSingleWord(string inputOne)
        {
            char[] charsToTrim = { ',', '{', ' ', '~', '`', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '+', '='};        
            string singleInputWithoutCharacters = inputOne.Trim(charsToTrim);
            return singleInputWithoutCharacters;
        }

        //public string RemoveCharactersFromStringWords(string inputTwo)
        //{
        //    char[] charsToTrim = { ',', '{', '~', '`', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '+', '=' };
        //    string wordsInputWithoutCharacters = inputTwo.Replace(charsToTrim, 'd');
        //    return wordsInputWithoutCharacters;
        //}

        public static int Final(string inputOne, string inputTwo)
        {
                //.CountStringOccurrences(s1, "Sam")
            //int containsWord = inputTwo.Split(new[] { ','}).Count(s => s == inputOne);;
            


            int count = 0;
            int i = 0;
            while ((i = inputOne.IndexOf(inputTwo, i)) != -1)
            {
                i += inputTwo.Length;
                count++;
            }
            return count;
        
        }
    }
}
