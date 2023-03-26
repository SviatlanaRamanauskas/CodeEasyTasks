using System;

namespace Static
{
    static class TextFramePretifierS
    {
        private static int _textsPretified;
        static TextFramePretifierS()
        {
            _textsPretified = 0;
        }
        public static void Prettify(string text, int length) // method
        {
            _textsPretified++;
            Console.WriteLine($"Processing text: {_textsPretified}");
            string[] words = text.Split(' ');
            for (int i = 0; i < length; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.Write("*");

            int charsNumber = 0;
            for (int i = 0; i < words.Length; i++) // loop for letters of word
            {
                charsNumber = charsNumber + words[i].Length; // add a word to number of char
                if (charsNumber <= length - 4)
                {
                    Console.Write($" {words[i]}"); // words with space in begining
                    charsNumber++;// space between words inclided 
                }
                else if (charsNumber > length - 4) // spaces till the end of row
                {
                    charsNumber = charsNumber - words[i].Length;
                    for (int j = charsNumber; j < length - 3; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(" *");
                    Console.WriteLine();
                    charsNumber = words[i].Length + 1;
                    Console.Write($"* {words[i]}");
                }
                if (i == words.Length - 1) // the last word
                {
                    for (int k = charsNumber; k < length - 3; k++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(" *");
                }
            }
            Console.WriteLine();
            for (int i = 0; i < length; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    class PresidentIsEvenMoreWeird
    {
        public static void Main()
        {
            int width = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            while (input != "exit")
            {
                TextFramePretifierS.Prettify(input, width);
                input = Console.ReadLine();
            }
        }
    }
}