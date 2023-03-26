using System;

namespace Methods
{
    class FunctionalModule
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while (command != "exit")
            {
                char firstChar = command[0];
                    if (((firstChar >= 'a') && (firstChar <= 'f')) || ((firstChar >= 'A') && (firstChar <= 'F')))
                    {
                        FromAToF(command);
                    }
                    else if (((firstChar >= 'g') && (firstChar <= 'l')) || ((firstChar >= 'G') && (firstChar <= 'L')))
                    {
                        FromGToL(command);
                    }
                    else if (((firstChar >= 'm') && (firstChar <= 'r')) || ((firstChar >= 'M') && (firstChar <= 'R')))
                    {
                        FromMToR(command);
                    }
                    else if (((firstChar >= 's') && (firstChar <= 'z')) || ((firstChar >= 'S') && (firstChar <= 'Z')))
                    {
                        FromSToZ(command);
                    }
                command = Console.ReadLine();
            }
        }
        
        static void FromAToF(string command)
        {
            Console.WriteLine($"FromAToF executes {command}.");
        }

        static void FromGToL(string command)
        {
            Console.WriteLine($"FromGToL executes {command}.");
        }

        static void FromMToR(string command)
        {
            Console.WriteLine($"FromMToR executes {command}.");
        }

        static void FromSToZ(string command)
        {
            Console.WriteLine($"FromSToZ executes {command}.");
        }
    }
}