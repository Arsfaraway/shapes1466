using System;

namespace ShapesLibrary
{
    internal class Square : IShape
    {
        public int X { get; }
        public int Y { get; }
        public int L { get; }

        public Square(int x, int y, int l)
        {
            X = x;
            Y = y;
            L = l;
        }

        public void Draw()
        {
            Console.WriteLine($"Square at ({X}, {Y}), side = {L}");
        }

        public double Perimeter()
        {
            return 4 * L;
        }

        public double Square1()
        {
            return L * L;
        }
    }
}
