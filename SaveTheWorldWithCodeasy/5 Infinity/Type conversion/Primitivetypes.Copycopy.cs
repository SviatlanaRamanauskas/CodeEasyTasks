using System;

namespace PrimitiveTypes
{
    class CopyCopy
    {
        static void Main(string[] args)
        {
            byte a = 10;
            short aCopy = a;
            int aCopyCopy = aCopy;


            Console.WriteLine(aCopyCopy);
        }
    }
}