using System;

namespace ParametersToMethods
{
    class HowManyZer0sInT0tal
    {
        static void Main()
        {
            var count = int.Parse(Console.ReadLine());
            int numberOfZeros = 0;
            string input = null;
            for (int i = 0; i < count; i++)
            {
                input = Console.ReadLine();
                AnalyzeString(input, ref numberOfZeros);
            }
            if (numberOfZeros > 0)
                Console.WriteLine(numberOfZeros);
            else
                Console.WriteLine("All strings are invalid.");

        }

        static bool AnalyzeString(string input, ref int numberOfZeros)
        {
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