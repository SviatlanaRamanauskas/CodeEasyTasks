using System;

namespace ParametersToMethods
{
    class FillTheArrayNow
    {
        static void Main()
        {
            var myArray = new int[10]; //0000000000
            var commandsCount = int.Parse(Console.ReadLine());// 4
            for (int k = 0; k < commandsCount; k++) // READING users commands 
            {
                string myString = Console.ReadLine();
                int index = int.Parse(myString[5].ToString());
                if (myString == ($"add1 {index}"))
                    PutOneAtIndex(myArray, index);
                if (myString == ($"add0 {index}"))
                    PutZeroAtIndex(myArray, index);
            }
            // Write your code here
            for (int i = 0; i < myArray.Length; i++)// WRITING the array with numbers
            {
                Console.Write(myArray[i]);
                if (i != myArray.Length - 1)
                    Console.Write(" ");
            }
        }

        static void PutOneAtIndex(int[] theArray, int index)
        {
            for (int i = 0; i < theArray.Length; i++)
            {
                if (i == index)
                    theArray[i] = 1;
            }// Write 1 to the array cell with index index
        }

        static void PutZeroAtIndex(int[] theArray, int index)
        {
            for (int i = 0; i < theArray.Length; i++)
            {
                if (i == index)
                    theArray[i] = 0;
            }// Write 0 to the array cell with index index
        }
    }
}