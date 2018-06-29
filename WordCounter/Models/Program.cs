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
            string inputOne = testRepeatCounter.RemoveSpacesandCharactersFromSingleWord(initalInputOne);
            string inputTwo = testRepeatCounter.RemoveCharactersFromStringWords(initalInputTwo);
            testRepeatCounter.Final(inputOne, inputTwo);
        }
    }
}
