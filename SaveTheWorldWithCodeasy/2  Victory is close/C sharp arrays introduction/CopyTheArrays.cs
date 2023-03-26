using System;

namespace Arrays
{
    class ArraysCopy
    {
        public static void Main(string[] args)
        {
            double[] myArray = GetNumbersFromConsole();

            double[] copy = new double[myArray.Length]; //copy of array - length
            for (int i = 0; i < myArray.Length; ++i)
            {
                copy[i] = myArray[i];// values of all cells. (0 = 1.12;1= 2.99; 2 = 
            }
            for (int i = 0; i < myArray.Length; ++i)
            {
                Console.WriteLine(copy[i]);
            }
            // Write your code here
        }

        static double[] GetNumbersFromConsole()
        {
            int count = int.Parse(Console.ReadLine());// inputs 3
            double[] result = new double[count]; // array from 3 cells

            for (int i = 0; i < count; ++i)
            {
                result[i] = double.Parse(Console.ReadLine()); // user inputs doubles (1.12)
            }
            return result; // 1.12
        }
    }
}