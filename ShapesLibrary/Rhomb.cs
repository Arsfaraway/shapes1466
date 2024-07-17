using System;

namespace ShapesLibrary
{
    internal class Rhomb : IShape
    {
        public int X { get; }
        public int Y { get; }
        public int H { get; }
        public int W { get; }

        public Rhomb(int x, int y, int h, int w)
        {
            X = x;
            Y = y;
            H = h;
            W = w;
        }

        public void Draw()
        {
            Console.WriteLine($"Rhomb at ({X}, {Y}), height = {H}, weight = {W}");
        }

        public double Perimeter()
        {
            return 4 * Math.Sqrt((Math.Pow(W, 4)) / (4 * (Math.Pow(W, 2) - Math.Pow(H, 2))));
        }

        public double Square1()
        {
            return H * Math.Sqrt((Math.Pow(W, 4)) /(4 * (Math.Pow(W, 2) - Math.Pow(H, 2))));
        }
    }
}
