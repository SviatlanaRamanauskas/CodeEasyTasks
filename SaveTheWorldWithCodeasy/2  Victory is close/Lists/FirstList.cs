using System;
using System.Collections.Generic;

namespace Lists
{
    public class Lists
    {
        static void Main(string[] args)
        {
            List<int> myNumbers = new List<int>();
            myNumbers.Add(10);
            myNumbers.Add(20);
            myNumbers.Add(34);
            myNumbers.Add(50);
            Console.WriteLine(myNumbers[0]);
            Console.WriteLine(myNumbers[1]);
            Console.WriteLine(myNumbers[2]);
            Console.WriteLine(myNumbers[3]);

        }
    }
}