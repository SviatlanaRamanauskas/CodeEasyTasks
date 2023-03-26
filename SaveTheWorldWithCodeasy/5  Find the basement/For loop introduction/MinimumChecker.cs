using System;

namespace ForLoops
{
    class Minimum
    {
        static void Main(string[] args)
        {
            int min = 100000000;
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)// Write your code here
            {
                int number = int.Parse(Console.ReadLine());
                if (number < min)
                {
                    min = number;
                    {
                        Console.WriteLine(min);
                    }
                }
            }
        }
    }
}
