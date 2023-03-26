using System;

namespace Exam
{
    class InsertAtIndex
    {
        static void Main()
        {
            double[] myArray = GetNumbersFromConsole();
            int insertIndex = int.Parse(Console.ReadLine());
            double temp = 0;
            temp = myArray[insertIndex];
            double elementToInsert = double.Parse(Console.ReadLine());

            for (int i = 0; i <= insertIndex; i++)
            {
                if (i == insertIndex)
                {
                    myArray[insertIndex] = elementToInsert;
                    Console.Write(myArray[insertIndex]);
                    Console.Write(",");
                    Console.Write(temp);
                    Console.Write(",");
                }
                else
                {
                    Console.Write(myArray[i]);
                    Console.Write(",");
                }
            }
            for (int i = insertIndex + 1; i < myArray.Length - 1; i++)
            {
                Console.Write(myArray[i]);
                if (i != myArray.Length - 2)
                    Console.Write(",");
            }
        }

        static double[] GetNumbersFromConsole()
        {
            int count = int.Parse(Console.ReadLine());
            double[] result = new double[count + 1]; // One extra element in the end

            for (int i = 0; i < count; ++i)
            {
                result[i] = double.Parse(Console.ReadLine());
            }

            return result;
        }
    }
}