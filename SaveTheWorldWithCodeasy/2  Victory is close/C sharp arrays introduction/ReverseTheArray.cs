using System;

namespace Arrays
{
    class ReverseArray
    {
        public static void Main(string[] args)
        {
            int[] myArray = GetNumbersFromConsole();
            for (int i = myArray.Length - 1; i >= 0; --i)
            {
                Console.Write(myArray[i]);
                if (i > 0)
                {
                    Console.Write(" ");
                }
            }

        }

        static int[] GetNumbersFromConsole()
        {
            int count = int.Parse(Console.ReadLine()); //3
            int[] result = new int[count]; //genetared array only cells 0 1 2 

            for (int i = 0; i < count; ++i)
            {
                result[i] = int.Parse(Console.ReadLine()); // repeating array to input numbers
            }

            return result; //my array (numbers) 5 6 7
        }
    }
}