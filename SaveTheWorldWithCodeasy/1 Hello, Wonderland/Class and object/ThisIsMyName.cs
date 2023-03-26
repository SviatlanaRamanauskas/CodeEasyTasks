using System;

namespace ClasAndObject
{
    class User
    {
        public int Age;
        public string Name;
    }
    public class ThisIsMyName
    {
        public static void Main()
        {
            var smb = new User
            {
                Name = "Teo",
                Age = 24
            };
            Console.WriteLine($"My name is {smb.Name} and I'm {smb.Age} years old.");
            /* Create object here */
        }
    }
}