using System;

namespace Arrays
{
    class SumOfArray
    {
        public static void Main(string[] args)
        {
            int[] myArray = GetNumbersFromConsole();
            int number = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                number = myArray[i] + number;
                // Write your code here
            }
            Console.WriteLine($"Sum: {number}");


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