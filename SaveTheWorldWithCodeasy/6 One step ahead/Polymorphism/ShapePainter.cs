using System;

namespace Polymorphism
{
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Can't draw unknown shape");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("+=======+");
            Console.WriteLine("|       |");
            Console.WriteLine("+=======+");
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("  #");
            Console.WriteLine(" ###");
            Console.WriteLine("#####");
        }
    }

    public class ShapePainter
    {
        public static void Main()
        {
            var whatToDraw = Console.ReadLine();

            if (whatToDraw == "rectangle")
            {
                // Write your code here
                Rectangle rectangle = new Rectangle();
                DrawShape(rectangle);
            }
            else if (whatToDraw == "triangle")
            {
                // Write your code here
                Triangle triangle = new Triangle();
                DrawShape(triangle);
            }
            else
            {
                Shape shape = new Shape();
                DrawShape(shape);
            }
        }

        private static void DrawShape(Shape shape)
        {
            shape.Draw();
        }
    }
}