using System;

namespace ForLoops
{
    class EvenSum
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 150; i < 250; i++)
            {
                sum = sum + i;
            }
            {
                Console.WriteLine(sum);
            }// Write your code here
        }
    }
}
