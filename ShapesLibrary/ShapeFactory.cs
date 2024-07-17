using System;

namespace ShapesLibrary
{
    public class ShapeFactory
    {
        public static object CreateShape(string description)
        {
            var parts = description.Split();
            var type = parts[0].ToLower();

            switch (type)
            {
                case "point":
                    return new Point(int.Parse(parts[1]), int.Parse(parts[2]));
                case "rect":
                    return new Rect(int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]));
                case "line":
                    return new Line(int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]));
                case "square":
                    return new Square(int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[3]));
                case "rhomb":
                    return new Rhomb(int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]));
                case "circle":
                    return new Circle(int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[3]));
                default:
                    throw new ArgumentException("Invalid shape description");
            }
        }
    }
}
