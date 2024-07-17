using System;

namespace ShapesLibrary
{
    internal class Point : IShape
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Draw()
        {
            Console.WriteLine($"Point at ({X}, {Y})");
        }

        public double Perimeter()
        {
            return 0;
        }

        public double Square1()
        {
            return 0;
        }
    }
}
