using System;

namespace Booleans
{
    class RoadsObserver
    {     
        static void Main(string[] args)
        {
            int roadsFromAToB = 3;
            int roadsFromBToC = 4;
            int roadsFromAToC;

            if ((roadsFromAToB + roadsFromBToC) > 10)
            {
                Console.WriteLine("I can check them all.");
            }
            else
            {
                Console.WriteLine("I can't check them all.");
            }
        }
    }
}
