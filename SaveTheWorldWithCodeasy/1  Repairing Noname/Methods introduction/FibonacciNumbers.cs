using System;

namespace Methods
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int beforePrevious = 1;
            int previous = 1;
            Console.Write(beforePrevious + " " + previous);

            for (int i = 0; i < n; i++)
            {
                int next = GetNextFibonacci(beforePrevious, previous);
                Console.Write(" " + next);

                beforePrevious = previous;
                previous = next;
            }
        }

        static int GetNextFibonacci(int number1, int number2)
        {
            int next = number1 + number2;
            return next;
        }
    }
}