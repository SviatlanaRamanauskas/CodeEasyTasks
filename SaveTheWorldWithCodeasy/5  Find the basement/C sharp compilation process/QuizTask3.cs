using System;

namespace NetFramework
{
    class Quiz3
    {
        static void Main(string[] args)
        {
            // Select correct here
            int index = -1;

            string question = "Which files does C# compiler generate?";
            string answer = "";

            if (index == 0)
                answer = "- ProgramName.exe or ProgramName.il";

            if (index == 1)
                answer = "- ProgramName.dll. or ProgramName.il";

            if (index == 2)
                answer = "- ProgramName.il or ProgramName.bat";

            if (index == 3)
                answer = "- ProgramName.exe or ProgramName.dll";

            Console.WriteLine(question);
            Console.WriteLine(answer);
        }
    }
}
