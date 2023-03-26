using System;

namespace NetFramework
{
    class Quiz6
    {
        static void Main(string[] args)
        {
            // Select correct here
            int index = -1;

            string question = "What happens if you miss a semicolon in your code?";
            string answer = "";

            if (index == 0)
                answer = "- You get compile time error telling you what went wrong.";

            if (index == 1)
                answer = "- You get runtime error telling you what went wrong.";

            if (index == 2)
                answer = "- You get CLR error tlling you what went wrong.";

            if (index == 3)
                answer = "- You get operating system error telling you what went wrong.";

            Console.WriteLine(question);
            Console.WriteLine(answer);
        }
    }
}
