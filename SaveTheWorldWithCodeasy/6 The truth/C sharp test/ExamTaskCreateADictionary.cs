using System;

namespace Exam
{
    class DivideString
    {
        static void Main()
        {
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    Console.Write(input[i]);
                }
                else if (((input[i] == ' ') || (input[i] == ',') || (input[i] == '.') || (input[i] == '?') || (input[i] == '!')) && (char.IsLetter(input[i + 1]) && (i < input.Length - 1)))
                {
                    Console.WriteLine();
                }

            }
        }
    }
}