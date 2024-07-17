using System;

namespace ShapesLibrary
{
    internal class Line : IShape
    {
        public int X1 { get; }
        public int Y1 { get; }
        public int X2 { get; }
        public int Y2 { get; }

        public Line(int x1, int y1, int x2, int y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }

        public void Draw()
        {
            Console.WriteLine($"Line from ({X1}, {Y1}) to ({X2}, {Y2})");
        }

        public double Perimeter()
        {
            return Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
        }

        public double Square1()
        {
            return 0;
        }
    }
}
