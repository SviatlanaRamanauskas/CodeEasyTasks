using System;

namespace Booleans
{
    public class VirusesStorage
    {
        public static void Main(string[] args)
        {
            bool virusIsActivated = false;
            int virusCost = 20;
            if (!virusIsActivated && (virusCost > 15))
            {
                Console.WriteLine("Save to internal storage.");
            }
            else
            {
                Console.WriteLine("Throw away.");
            }
        }
    }
}
