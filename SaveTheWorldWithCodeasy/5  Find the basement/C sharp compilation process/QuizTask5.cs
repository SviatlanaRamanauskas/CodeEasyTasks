using System;

namespace NetFramework
{
    class Quiz5
    {
        static void Main(string[] args)
        {
            // Select correct here
            int index = -1;

            string question = "What is .NET Framework?";
            string answer = "";

            if (index == 0)
                answer = "- Framework that contains CLR, big class library and other software that makes possible to execute C# programs.";

            if (index == 1)
                answer = "- Framework that was developed to support C# programs on Linux and Mac OS.";

            if (index == 2)
                answer = "- Framework that contains CLR, big class library and other software that makes possible to execute C#, F# and Visual Basic .NET programs.";

            if (index == 3)
                answer = "- A component of CLR, includes JIT compiler.";

            Console.WriteLine(question);
            Console.WriteLine(answer);
        }
    }
}
