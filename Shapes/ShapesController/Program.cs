using System.Collections.Generic;
using ShapeLibrary;

// ReSharper disable All

namespace ShapesController
{
    internal static class Program
    {
        private static void Main()
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

public interface IAbc
{
    // A
    void A();
    void AA();
    void AAA();

    // B
    void B();
    void BB();

    // C
    void C();
}
