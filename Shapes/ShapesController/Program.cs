using System.Collections.Generic;
using ShapeLibrary;

namespace ShapesController
{
    internal static class Program
    {
        private static void Main()
        {
            var shapes = new List<IShape>
            {
                new Square()
            };

            Display(shapes);
            Animate(new Line());
        }

        private static void Display(IEnumerable<IShape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Display();
            }
        }

        private static void Animate(IShape shape)
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
