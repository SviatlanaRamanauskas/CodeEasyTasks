using System;

namespace WhileLoop
{
    class SalaryNegotiator
    {
        static void Main(string[] args)
        {
            bool giveMoreSalary = true;
            int startSalary = 100;

            while (giveMoreSalary)
            {
                Console.WriteLine($"I will give you {startSalary} dollars, ok?");
                string answer = Console.ReadLine();
                if (answer == "more")
                {
                    startSalary = startSalary + 100;
                }
                if (answer == "ok")
                {
                    giveMoreSalary = false;
                    Console.WriteLine($"Your salary is {startSalary} dollars.");
                }

            }
        }
    }
}