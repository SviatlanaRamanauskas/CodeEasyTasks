using System;

namespace LearningVar
{
    class DoubleSpaces
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();
            for (var i = 0; i < input.Length; ++i)
            {
                if ((input[i] == ' ') && (input[i + 1] == ' '))
                {
                    Console.Write("");
                }
                else if (((input[i] == ' ') && (input[i + 1] != ' ')) || (input[i] != ' '))
                {
                    Console.Write(input[i]);
                }
            }
        }
    }
}