using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        public static bool IsValidEntry(string inputWord, string inputSentence)
        {
            bool result = true;

            if (inputWord.Length > inputSentence.Length)
            {
                result = false;
            }
            return result;
        }
        // public static string CountInSentence(string inputWord, string inputSentence)
        // {
        //     int counter = 0; 
        //     string oneWord = inputWord;
        //     string[] words = inputSentence.Split();

        //     foreach (string word in words)
        //     {
        //
        //         CheckForMatch(oneWord);
        //         counter += 1;
        //     }

        //     return counter;
        // }
        public static bool CheckForMatchInSentence(string inputWord, string inputSentence)
        {
            bool result = false;
            string word = inputWord;
            string sentence = inputSentence;

            if (word.Equals(""))
            {
                result = true;
            }
            
            return result;
        }
    }
}