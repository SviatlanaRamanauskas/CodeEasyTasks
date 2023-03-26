using System;

namespace SwitchStatement
{
    class AccessChecker
    {
        static void Main()
        {
            string userName = Console.ReadLine();
            switch (userName)
            {
                case "admin":
                    Console.WriteLine("Welcome! Full access granted.");
                    break;
                case "user":
                    Console.WriteLine("Welcome! Limited access granted.");
                    break;
                default:
                    Console.WriteLine("Unknown user.");
                    break;
            }
        }
    }
}