using System;
using WordCounter;

namespace WordCounterMain
{
    class Program
    {
        static void Main(string[] args)
        {
            string initalInputOne = "Dog!";
            string initalInputTwo = "Is your dog happ$y";
            RepeatCounter testRepeatCounter = new RepeatCounter();
            string inputOneScrub = testRepeatCounter.RemoveSpacesandCharactersFromSingleWord(initalInputOne);
            string inputTwoScrub = testRepeatCounter.RemoveCharactersFromStringWords(initalInputTwo);
            string inputOneForFinal = testRepeatCounter.ConvertSingleWordToLowerCase(inputOneScrub);
            string inputTwoForFinal = testRepeatCounter.ConvertStringOfWordsToLowerCase(inputTwoScrub);
            int numberOfOccurences = testRepeatCounter.Final(inputOneForFinal, inputTwoForFinal);
            Console.WriteLine(numberOfOccurences);
        }
    }
}
