using System;

namespace LearningConst
{
    class BrokenVirus
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Checking self destruction options.");
            string input = Console.ReadLine();
            string selfDestructionAvailable = input;

            if (selfDestructionAvailable == "available")
            {
                Console.WriteLine("Start self destruction. RIP, machine.");
            }
            else
            {
                Console.WriteLine("Turning off.");
            }
        }
    }
}