using System;

namespace Methods
{
    class SayHelloToMe
    {
        static void Main(string[] args)
        {
            string smbName = Console.ReadLine();
            SayHello(smbName);
        }
        static void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}