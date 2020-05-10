using System.Collections.Generic;
using ShapeLibrary;

namespace ShapesController
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var shapes = new List<Shape>
            {
                new Square()
            };

            Display(shapes);
            Animate(new Line());
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
    }
}
