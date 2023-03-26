using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace Null
{
    class PigLatin
    { 
        public static void Main()
        {
            string englishPhrase = Console.ReadLine();// Write your code here
            string[] words = englishPhrase.Split(" ");

            for (int k = 0; k < words.Length; k++)
            {
                var word = words[k];
                char firstChar = word[0];
                for (int i =1; i < word.Length; i++)
                {
                    Console.Write(word[i]);
                }
                Console.Write(firstChar + "ay" + " ");
            }

        }
    }
}