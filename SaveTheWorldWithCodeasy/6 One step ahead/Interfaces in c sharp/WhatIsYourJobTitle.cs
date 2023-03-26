using System;

namespace Interfaces
{
    public class Programmer
    {
        void WriteCode()
        {
            Console.WriteLine("I'm a good coder!");
        }
    }

    public interface ISoftwareDeveloper
    {
        string JobTitle { get; }
    }

    public class Me : Programmer, ISoftwareDeveloper
    {
        public string JobTitle
        {
            get
            {
                return "Chief Hacking Officer";
            }
        }
    }

    public class WhatsYourJobTitle
    {
        public static void Main()
        {
            var me = new Me();

            Console.WriteLine(me.JobTitle);
        }
    }
}