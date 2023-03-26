using System;

namespace NetFramework
{
    class Quiz1
    {
        static void Main(string[] args)
        {
            // Select correct here
            int index = 2;

            string question = "What is compiler?";
            string answer = "";

            if (index == 0)
                answer = "- A program that executes my code.";

            if (index == 1)
                answer = "- A framework that is running in Windows.";

            if (index == 2)
                answer = "- A program that transforms code written in one programming language into another.";

            if (index == 3)
                answer = "- A service that tries to recover your program if you made a mistake.";

            Console.WriteLine(question);
            Console.WriteLine(answer);
        }
    }
}
