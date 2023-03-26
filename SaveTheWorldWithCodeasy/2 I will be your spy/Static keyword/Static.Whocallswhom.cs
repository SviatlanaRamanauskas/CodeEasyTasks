using System;

namespace Static
{
    class WhoCallsWhom
    {
        private static int _a;

        static void SetA(int a)
        {
            _a = a;
        }

        static void SayWisdom()
        {
            Console.WriteLine("Noname is the best human friend.");
        }

        public static void Main()
        {
            SayWisdom();
        }
    }
}