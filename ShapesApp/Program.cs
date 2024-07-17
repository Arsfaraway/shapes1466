using ShapesLibrary;
using System;
using System.IO;

namespace ShapesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string filePath = Path.Combine(projectDirectory, "shapes.txt");

            Console.WriteLine(filePath);   

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    try
                    {

                        IShape shape = (IShape)ShapeFactory.CreateShape(line);

                        shape.Draw();
                        Console.WriteLine($"Perimeter: {shape.Perimeter().ToString("F3")}");
                        Console.WriteLine($"Square: {shape.Square1().ToString("F3")}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при создании фигуры: {ex.Message}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Файл \"shapes.txt\" не найден.");
            }

            Console.ReadLine();
        }
    }
}
