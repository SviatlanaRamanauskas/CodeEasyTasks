using System;

namespace Null
{
    class Sloppy
    {
        public static void Main()
        {
            int counter = 1;

            counter++;
            counter--;
            
            Console.WriteLine(counter);

            string name = "Max";

            name = name + "Sue";
            name = name + " :)";

            Console.WriteLine(name);
        }
    }
}