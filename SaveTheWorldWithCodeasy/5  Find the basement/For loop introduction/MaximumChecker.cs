using System;

namespace ForLoops
{
    class Maximum
    {
        static void Main(string[] args)
        {
            int max = -10000000;
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > max)
                {
                    max = number;
                    {
                        Console.WriteLine(max);
                    }
                }// Write your code here
            }
        }
    }
}
