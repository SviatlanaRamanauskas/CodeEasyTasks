using System;

namespace WhileLoop
{
    class TriangleWhile
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int i = 0;
            while (i < count)
            {
                int j = 0;
                while (j <= i)
                {
                    Console.Write("#");
                    j++;
                }
                Console.WriteLine();
                i++;
            }

        }
    }
}