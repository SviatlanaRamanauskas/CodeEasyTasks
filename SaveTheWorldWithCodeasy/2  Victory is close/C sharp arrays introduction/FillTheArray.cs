using System;

namespace Arrays
{
    class FillArray
    {
        public static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] sizeCount = new int[count];

            for (int i = 0; i < count; ++i)
            {
                sizeCount[i] = i;
            }
            for (int i = 0; i < count; ++i)
            {
                Console.WriteLine(sizeCount[i]);
            }
        }
    }
}