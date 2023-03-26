using System;

namespace ParametersToMethods
{
    class TrickySum
    {
        static void Main()
        {
            int mySum = 0;
            for (int i = 0; i < 10; i++)
            {
                AddToSum(ref mySum, i);
            }

            Console.WriteLine(mySum);
        }

        static void AddToSum(ref int sum, int valueToAdd)
        {
            sum = sum + valueToAdd;
        }
    }
}