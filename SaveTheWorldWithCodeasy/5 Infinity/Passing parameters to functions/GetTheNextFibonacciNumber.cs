using System;

namespace ParametersToMethods
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int previous = 1;
            int current = 1;
            Console.Write("1 1");

            for (int i = 0; i < n - 2; ++i)
            {
                Console.Write(" ");

                GetNextFibonacci(ref previous, ref current);
                Console.Write(current);
            }
        }

        static void GetNextFibonacci(ref int previous, ref int current)
        {
            int tmp = current;
            current = previous + current;
            previous = tmp;
        }
    }
}
