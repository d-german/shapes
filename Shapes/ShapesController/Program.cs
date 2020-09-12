using System;
using System.Collections.Generic;
using ShapeLibrary;

namespace ShapesController
{
    internal static class Program
    {
        private static void Main()
        {
            var shapes = new List<Shape>
            {
                new Square {Length = 1, Width = 1}
            };

            Display(shapes);
            Animate(new Line());
            PrintArea(shapes);
        }

        private static void Display(IEnumerable<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Display();
            }
        }

        private static void Animate(Shape shape)
        {
            var currentLocation = shape.GetLocation();

            shape.SetLocation(new Point
            {
                X = ++currentLocation.X,
                Y = --currentLocation.X
            });
        }

        private static void PrintArea(IEnumerable<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                Console.WriteLine($"Area = {shape.Area}");
            }
        }
    }
}
