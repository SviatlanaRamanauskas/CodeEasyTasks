using System;

namespace Exceptions
{
    public class IntParseWithExceptions
    {
        public static void Main()
        {
            try
            {
                var port = int.Parse(Console.ReadLine());
                var message = Console.ReadLine();

                Console.WriteLine($"Sending message {message} to the port {port}");
            }

            catch(FormatException)
            {
                Console.WriteLine("Port that you provided is not a number.");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Port that you provided is too big.");
            }

        }
    }
}