using System;

namespace Exam
{
    class SecureFrequencies
    {
        static void Main()
        {
            bool finished = false;
            while (!finished)
            {
                string stringInput = Console.ReadLine();

                if (stringInput == "finished")
                {
                    finished = true;
                }
                else
                {
                    int frequency = int.Parse(stringInput);
                    FrequencyIsSecure(frequency);
                }
            }

        }

        static bool FrequencyIsSecure(int frequency)
        {

            if (frequency % 5 == 0)
            {
                Console.WriteLine("insecure");
            }
            else if (frequency % 5 != 0)
            {
                Console.WriteLine("secure");
            }
            return true;
        }
    }
}