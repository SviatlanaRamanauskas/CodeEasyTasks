using System;

namespace PrimitiveTypes
{
    class ArrayAverage
    {
        public static void Main(string[] args)
        {
            int[] myArray = GetNumbersFromConsole();
            double sum = 0;
            for (int i = 0; i < myArray.Length; ++i)
                sum = sum + (double)myArray[i];
            double average = sum / (double)myArray.Length;
            Console.WriteLine(average);// Write your code here
        }

        static int[] GetNumbersFromConsole()
        {
            double sum = 0;
            int count = int.Parse(Console.ReadLine());//4 input
            int[] result = new int[count];// array created, result - numbers

            for (int i = 0; i < count; ++i)// 4 times lop works
            {
                result[i] = int.Parse(Console.ReadLine());// numbers and indexes
            }

            return result;// array
        }
    }
}