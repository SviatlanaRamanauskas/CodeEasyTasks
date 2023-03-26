using System;

namespace ForLoops
{
    class IKnowWhereYouLive
    {
        static void Main(string[] args)
        {
            string CountFromTheConsoleString = Console.ReadLine();
            int CountFromTheConsole = int.Parse(CountFromTheConsoleString);// Write your code here
            for (int i = 0; i < CountFromTheConsole; i++)
            {
                Console.WriteLine("I know where you live.");
            }
        }
    }
}
