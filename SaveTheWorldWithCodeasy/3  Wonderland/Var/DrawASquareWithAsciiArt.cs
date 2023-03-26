using System;

namespace LearningVar
{
    class Square
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());// Don't forget to declare variable size with var
            var sideLength = size + 2;
            for (var f = 0; f < 1; f++)  // 1 for
            {
                for (var j = 0; j < sideLength; ++j)
                {
                    if ((j == 0) || (j == sideLength - 1))
                        Console.Write("+");
                    else
                        Console.Write("-");
                }
                Console.WriteLine();
            }
            for (var m = 0; m < size; m++)  // 2 for
            {
                for (var j = 0; j < sideLength; ++j)
                {
                    if ((j == 0) || (j == sideLength - 1))
                        Console.Write("|");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            for (var e = 0; e < 1; e++)  // 3 for
            {
                for (var j = 0; j < sideLength; ++j)
                {
                    if ((j == 0) || (j == sideLength - 1))
                        Console.Write("+");
                    else
                        Console.Write("-");
                }
                Console.WriteLine();

            }
        }
    }
}