using System;

namespace Exceptions
{
    public class DangerousException
    {
        public static void Main()
        {
            throw new Exception("I'm a dangerous exception!");
        }
    }
}