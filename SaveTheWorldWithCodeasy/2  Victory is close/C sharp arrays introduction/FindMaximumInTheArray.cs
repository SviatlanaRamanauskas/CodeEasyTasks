using System;

namespace Arrays
{
    class MaxInArray
    {
        public static void Main(string[] args)
        {
            double[] numbers = GetNumbersFromConsole(); //array
            double number = numbers[0];// initial number 0 of our result in console->{number}
            for (int i = 0; i < numbers.Length; ++i) // repite iteration to find MAX and output
                if (numbers[i] > number)
                {
                    number = numbers[i];
                }
            Console.WriteLine($"Max is: {number}");// Write your code here
        }
        static double[] GetNumbersFromConsole()
        {
            int count = int.Parse(Console.ReadLine());
            double[] result = new double[count];

            for (int i = 0; i < count; ++i)
            {
                result[i] = double.Parse(Console.ReadLine());
            }

            return result;
        }
    }
}