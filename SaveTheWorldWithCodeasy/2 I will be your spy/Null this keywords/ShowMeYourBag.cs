using System;

namespace This
{
    class Box
    {
        public int Width;
        public int Height;
        public int Length;

        public string CompareTo(Box box)
        {
            if (Comparator.Compare(this, box) == 1) // Compare 2 boxes here and return the result    
                return "Bigger";
            else if (Comparator.Compare(this, box) == -1)
                return "Smaller";
            else
                return "Equal";
        }
    }

    class Comparator
    {
        public static int Compare(Box box1, Box box2)
        {
            var volume1 = box1.Width * box1.Height * box1.Length;
            var volume2 = box2.Width * box2.Height * box2.Length;

            if (volume1 > volume2)
                return 1;
            if (volume1 < volume2)
                return -1;

            return 0;
        }
    }

    class BoxComparator
    {
        public static void Main()
        {
            var box1 = new Box();
            int width1 = int.Parse(Console.ReadLine());// Create 2 boxes here and output the comparation result
            int height1 = int.Parse(Console.ReadLine());
            int length1 = int.Parse(Console.ReadLine());


            var box2 = new Box();
            int width2 = int.Parse(Console.ReadLine());
            int height2 = int.Parse(Console.ReadLine());
            int length2 = int.Parse(Console.ReadLine());

            box1.Width = width1;
            box1.Height = height1;
            box1.Length = length1;

            box2.Width = width2;
            box2.Height = height2;
            box2.Length = length2;

            Console.WriteLine(box1.CompareTo(box2));
        }
    }
}