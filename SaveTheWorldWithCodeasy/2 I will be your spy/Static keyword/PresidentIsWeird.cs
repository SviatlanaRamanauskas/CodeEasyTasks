using System;

namespace Static
{

    static class TextFramePretifier
    {
        private static int _textsPretified; // field 
        static TextFramePretifier() //constructor
        {
            _textsPretified = 0;
        }
        public static void Prettify(string text) // method
        {
            _textsPretified++;

            Console.WriteLine($"Processing text: {_textsPretified}");
            for (int i = 0; i < text.Length + 4; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.Write($"* {text} *");
            Console.WriteLine();
            for (int i = 0; i < text.Length + 4; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    class PresidentIsWeird
    {
        public static void Main()
        {
            bool finish = false;
            while (!finish)
            {
                string input = Console.ReadLine();
                if (input == "exit")
                    finish = true;
                else
                    TextFramePretifier.Prettify(input); // this method counts in variable _textsPretified
            }
        }
    }
}