using System;

namespace Booleans
{
    class Salutation
    {     
        static void Main(string[] args)
        {
            string hello = "Hello, ";

            bool isMachine = false;
            bool isDangerous = false;
            if (isMachine || isDangerous)
            {
                hello = hello + "enemy.";
            }
            else
            {
                hello = hello + "Teo.";
            }

            Console.WriteLine(hello);
        }
    }
}
