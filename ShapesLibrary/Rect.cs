using System;

namespace ShapesLibrary
{
    internal class Rect : IShape
    {
        public int X1 { get; }
        public int Y1 { get; }
        public int X2 { get; }
        public int Y2 { get; }

        public Rect(int x1, int y1, int x2, int y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }

        public void Draw()
        {
            Console.WriteLine($"Rect at ({X1}, {Y1}), ({X2}, {Y2})");
        }

        public double Perimeter()
        {
            return 2 * (Math.Abs(X2 - X1) + Math.Abs(Y2 - Y1));
        }

        public double Square1()
        {
            return Math.Abs(X2 - X1) * Math.Abs(Y2 - Y1);
        }
    }
}
