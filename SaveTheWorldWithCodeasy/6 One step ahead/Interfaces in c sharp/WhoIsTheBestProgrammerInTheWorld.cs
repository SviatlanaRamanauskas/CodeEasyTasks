using System;

namespace Interfaces
{
    public interface IBestInTheWorldProgrammer
    {
        void WriteCode();
        void ReadDocumentation();
        void GetHighSalary();
        void EnloyLife();
    }

    public class BestInTheWorldProgrammer : IBestInTheWorldProgrammer
    {
        public void ReadDocumentation()
        {
            Console.WriteLine("Sometimes I read the documentation.");
        }

        public void WriteCode()
        {
            Console.WriteLine("I adore writing code!");
        }

        public void EnloyLife()
        {
            Console.WriteLine("I Love my life!");
        }

        public void GetHighSalary()
        {
            Console.WriteLine("Getting high salary... That's good!");
        }
    }

    public class WhoIsTheBestInTheWorldProgrammer
    {
        public static void Main()
        {
            var me = new BestInTheWorldProgrammer();

            me.ReadDocumentation();
            me.WriteCode();
            me.GetHighSalary();
            me.EnloyLife();
        }
    }
}