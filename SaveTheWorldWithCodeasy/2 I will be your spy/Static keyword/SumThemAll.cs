using System;

namespace Static
{

    class Mine
    {
        public static int GetSumBetween(int a, int b)
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
    }

    class SumThemAll
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Mine.GetSumBetween(a, b);

            Console.WriteLine(Mine.GetSumBetween(a, b));
        }
    }
}