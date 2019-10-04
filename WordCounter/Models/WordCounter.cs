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
        public static int CountMatchesInSentence(string inputWord, string inputSentence)
        {
            string matchWord = inputWord;
            // string sentence = inputSentence;
            int counter = 0;
            string[] words = inputSentence.Split();
            foreach (string word in words)
            {
                if (word.Equals(matchWord) == true)
                {
                    counter += 1;
                }             
            }  
            return counter;
        }
    }
}