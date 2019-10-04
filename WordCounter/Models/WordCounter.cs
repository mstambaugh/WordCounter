using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        public static bool IsValidEntry(string inputWord, string inputSentence)
        {
            bool result = true;

            if (inputWord.Length < inputSentence.Length)
            {
                result = false;
            }
            return result;
        }
    }
}