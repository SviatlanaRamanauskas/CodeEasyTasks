using System;

namespace Scopes
{
    class ASCIIArt
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int segment = width / 5;

            for (int i = 0; i < 7; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    if (j < segment - 1 || (j > 2 * segment && j < 3 * segment) || (j > 4 * segment && i != 4))
                        Console.Write("#");
                    else
                        Console.Write(" ");
                }

                Console.WriteLine();
            }

            for (int n = 0; n < 5; ++n)
            {
                for (int k = 0; k < width; ++k)
                {
                    if (k < 3 * segment || k > 4 * segment)
                        Console.Write("#");
                    else
                        Console.Write(" ");
                }

                Console.WriteLine();
            }

            for (int m = 0; m < 7; ++m)
            {
                for (int l = 0; l < width; ++l)
                {
                    if (l < segment - 1 || (l > 2 * segment && l < 3 * segment) || l > 4 * segment)
                        Console.Write("#");
                    else
                        Console.Write(" ");
                }

                Console.WriteLine();
            }
        }
    }
}