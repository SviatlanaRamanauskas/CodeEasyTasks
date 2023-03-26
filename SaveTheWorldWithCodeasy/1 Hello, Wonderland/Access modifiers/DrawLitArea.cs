using System;

namespace AccessModifiers
{
    class Point2D
    {
        public int X;
        public int Y;
    }
    class LitArea2D
    {
        private Point2D _topLeft;
        private Point2D _bottomRight;

        public LitArea2D(int xTopLeft, int yTopLeft, int xBottomRight, int yBottomRight)
        {
            _topLeft = new Point2D()
            {
                X = xTopLeft,
                Y = yTopLeft
            };

            _bottomRight = new Point2D()
            {
                Y = yBottomRight,
                X = xBottomRight
            };
        }

        public void Draw()
        {
            for (int j = 0; j <= _bottomRight.Y; j++)
            {
                for (int i = 0; i <= _bottomRight.X; i++)
                {
                    if ((i >= _topLeft.X) && (j >= _topLeft.Y))
                        Console.Write("#");
                    else
                        Console.Write(".");
                }
                Console.WriteLine();
            }
        }
    }

    // Write your code here

    class DrawLitArea
    {
        public static void Main()
        {
            int xTopLeft = int.Parse(Console.ReadLine()); // x top
            int yTopLeft = int.Parse(Console.ReadLine());// y top
            int xBottomRight = int.Parse(Console.ReadLine()); // x bottom
            int yBottomRight = int.Parse(Console.ReadLine()); // y bottom

            var nLitArea = new LitArea2D(xTopLeft, yTopLeft, xBottomRight, yBottomRight);
            nLitArea.Draw();

        }
    }
}