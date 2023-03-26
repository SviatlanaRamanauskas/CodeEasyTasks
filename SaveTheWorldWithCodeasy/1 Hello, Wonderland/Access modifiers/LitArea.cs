using System;

namespace AccessModifiers
{
    class Point
    {
        public int X;
        public int Y;
    }

    class LitArea
    {
        private Point _topLeft;
        private Point _bottomRight;

        public LitArea(int xTopLeft, int yTopLeft, int xBottomRight, int yBottomRight)
        {
            _topLeft = new Point()
            {
                X = xTopLeft,
                Y = yTopLeft
            };

            _bottomRight = new Point()
            {
                Y = yBottomRight,
                X = xBottomRight
            };


        }
    }
}