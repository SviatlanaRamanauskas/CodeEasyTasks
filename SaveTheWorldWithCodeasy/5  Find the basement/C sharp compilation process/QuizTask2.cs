using System;

namespace NetFramework
{
    class Quiz2
    {
        static void Main(string[] args)
        {
            // Select correct here
            int index = -1;

            string question = "What is machine code?";
            string answer = "";

            if (index == 0)
                answer = "- Code written in C#.";

            if (index == 1)
                answer = "- Code written in a way that processor can understand and execute it.";

            if (index == 2)
                answer = "- Code that Common Language Runtime can understand and execute.";

            if (index == 3)
                answer = "- It's not a code, it's another name of .NET Framework.";

            Console.WriteLine(question);
            Console.WriteLine(answer);
        }
    }
}
