using System;

namespace ParametersToMethods
{
    class HowManyZer0s
    {
        static void Main()
        {
            var input = Console.ReadLine();
            int numberOfZeros;


            if (AnalyzeString(input, out numberOfZeros))
            {
                Console.WriteLine(numberOfZeros);
            }
            else
            {
                Console.WriteLine("The string is invalid.");
            }
        }

        static bool AnalyzeString(string input, out int numberOfZeros)
        {
            numberOfZeros = 0;
            if (!string.IsNullOrEmpty(input))
            {

                foreach (char c in input)
                {
                    if (c == '0')
                    {
                        numberOfZeros++;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}