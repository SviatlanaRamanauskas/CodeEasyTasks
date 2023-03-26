using System;

namespace ForLoops
{
    class DiskSpace
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Input size of {i + 1} file:");
                sum = sum + int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Total disk space is {sum} bytes.");
        }
    }
}
