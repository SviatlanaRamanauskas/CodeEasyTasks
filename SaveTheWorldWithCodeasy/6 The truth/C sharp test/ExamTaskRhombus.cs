using System;

namespace Exam
{
    class Rhombus
    {
        static void Main()
        {

            var size = int.Parse(Console.ReadLine());
            int space = size - 1;
            int middle = space / 2;
            if ((size % 2 != 0) && (size >= 1))
            {
                for (int i = 0; i < middle + 1; i++) // run parent loop till number of rows 
                {

                    for (int j = 0; j < size; j++)
                    {
                        if (((j <= middle) && (j >= middle - i)) || ((j > middle) && (j <= middle + i)))
                            Console.Write("#");
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                for (int i = middle + 1; i < size; i++)// run parent loop till number of rows
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (((j <= middle) && (j >= Math.Abs(middle - i))) || ((j > middle) && ((space - j) >= (Math.Abs(middle - i)))))
                            Console.Write("#");
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}