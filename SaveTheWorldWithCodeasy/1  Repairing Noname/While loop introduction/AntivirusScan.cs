using System;

namespace WhileLoop
{
    class AntivirusScan
    {
        static void Main(string[] args)
        {
            string command;
            bool coastIsClear = true;
            string securityMode = "unhide";
            int number = 1;
            while (coastIsClear)
            {
                command = Console.ReadLine();
                if (command == "unhide" || command == "hide")
                {
                    securityMode = command;
                }
                else if (command == "scan")
                {
                    if (securityMode == "hide")
                    {
                        Console.WriteLine("can't scan files for viruses");
                    }
                    else
                    {
                        Console.WriteLine($"scanning file {number}");
                        number++;
                    }
                }
                else if (command == "game over")
                {
                    Console.WriteLine("run");
                    coastIsClear = false;
                }
            }

        }
    }
}