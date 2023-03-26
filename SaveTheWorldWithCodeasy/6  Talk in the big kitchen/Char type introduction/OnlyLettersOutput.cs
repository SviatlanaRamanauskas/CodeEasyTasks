using System;

namespace CharType
{
    class OnlyLetters
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                char someChar = Convert.ToChar(Console.Read());
                if (char.IsLetter(someChar))
                {
                    Console.Write(someChar);
                }

            }
        }
    }
}