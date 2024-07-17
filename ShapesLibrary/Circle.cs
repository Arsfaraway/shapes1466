using System;

namespace ShapesLibrary
{
    internal class Circle : IShape
    {
        public int X { get; }
        public int Y { get; }
        public int Radius { get; }

        public Circle(int x, int y, int r)
        {
            X = x;
            Y = y;
            Radius = r;
        }

        public void Draw()
        {
            Console.WriteLine($"Circle at ({X}, {Y}), radius = {Radius}");
        }

        public double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public double Square1()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
