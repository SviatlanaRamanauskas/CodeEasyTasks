using System;
using System.Runtime.CompilerServices;

namespace Exceptions
{
    public class WhichExceptionToCatch
    {
        static string[] MonthNames = new[] 
        {
            "Jannuary",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"
        };

        public static void Main()
        {
            int monthNumber = 0;
            int.TryParse(Console.ReadLine(), out monthNumber);

            try
            {
                GetMonthName(monthNumber);
            }
            catch (IndexOutOfRangeException ex)
            { 
                 Console.WriteLine(ex.Message);
            }
        }
        
        private static string GetMonthName(int monthNumber)
        {
            return MonthNames[monthNumber - 1];
        }
    }
}