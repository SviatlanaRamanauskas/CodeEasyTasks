using System;

namespace Arrays
{
    class SplitArray
    {
        public static void Main(string[] args)
        {
            int[] myArray = GetNumbersFromConsole();
            int[] bigArray = new int[myArray.Length];
            int[] smallArray = new int[myArray.Length];

            Console.Write("Big:");
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > 100)
                {
                    bigArray[i] = myArray[i];
                    Console.Write(" ");
                    Console.Write(bigArray[i]);
                }
            }
            Console.WriteLine();
            Console.Write("Little:");
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < 100)
                {
                    smallArray[i] = myArray[i];
                    Console.Write(" ");
                    Console.Write(smallArray[i]);
                }
            }
        }

        static int[] GetNumbersFromConsole()
        {
            int count = int.Parse(Console.ReadLine());
            int[] result = new int[count];

            for (int i = 0; i < count; ++i)
            {
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }
    }
}