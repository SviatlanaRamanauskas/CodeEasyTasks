using System;

namespace Exceptions
{
    public class GettingAccessWitchCatch
    {
        public static string Login { get; private set; }
        public static int NumericPassword { get; private set; }

        public static void Main()
        {
            try
            {
                Console.WriteLine("Enter login");
                var login = Console.ReadLine();

                Console.WriteLine("Enter numeric password");
                var numericPassword = int.Parse(Console.ReadLine());

                if (login == Login && numericPassword == NumericPassword)
                {
                    Console.WriteLine("Access granted");
                }
                else
                {
                    Console.WriteLine("Access denied");
                }
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Access granted");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong, restart the application and try again.");
            }
        }
    }
}