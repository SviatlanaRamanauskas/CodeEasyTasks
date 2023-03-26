using System;

namespace Exam
{
    class ClosestTo23
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = 0;
            if ((Math.Abs(a - 23) < Math.Abs(b - 23)) && (Math.Abs(a - 23) < Math.Abs(c - 23)))
            {
                d = a;
            }
            else if ((Math.Abs(b - 23) < Math.Abs(a - 23)) && (Math.Abs(b - 23) < Math.Abs(c - 23)))
            {
                d = b;
            }
            else if ((Math.Abs(c - 23) < Math.Abs(a - 23)) && (Math.Abs(c - 23) < Math.Abs(b - 23)))
            {
                d = c;
            }
            Console.WriteLine(d);
        }
    }
}