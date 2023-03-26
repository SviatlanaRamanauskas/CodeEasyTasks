using System;

namespace Inheritance
{
    class GeometricFigure
    {
        public virtual void Draw()
        {
            Console.WriteLine("Base drawing!");
        }
    }

    class Square : GeometricFigure
    {
        public int Size { get; set; }

        public override void Draw()
        {
            for(int j =0; j < Size; j++)
            {
                for(int i = 0; i < Size; i++)
                {
                    if(j == 0 || j == Size-1 || i==0 || i==Size-1)
                    Console.Write("#");
                    else
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            
        }// Override draw here
    }

    class Arrow : GeometricFigure
    {
        public int Length { get; set; }

        public override void Draw()
        {
            for(int i = 0; i < Length; i++)
            {
                if (i == Length - 1)
                    Console.Write(">");
                else
                    Console.Write("-");
            }
            Console.WriteLine();
        }// Override draw here
    }

    public class DrawMe
    {
        public static void Main()
        {
            var size = int.Parse(Console.ReadLine());

            var square = new Square { Size = size };
            var arrow = new Arrow { Length = size };

            square.Draw();
            arrow.Draw();
        }
    }
}