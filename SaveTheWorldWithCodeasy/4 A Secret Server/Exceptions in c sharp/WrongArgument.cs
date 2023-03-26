using System;

namespace Exceptions
{
    public class WrongArgument
    {
        public static void Main()
        {
            try
            {
                throw new ArgumentException("The argument is invalid!");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}