using ShapeLibrary;
using XShapeLibrary;

namespace ShapesController
{
    internal static class Program
    {
        private static void Main()
        {
            Circle circle = new Circle();

            circle.XDisplay();
            circle.Display();

            IShape circle1 = new Circle();

            circle1.Display();
            // circle1.XDisplay(); compile error

            XCircle circle2 = new Circle();

            circle2.XDisplay();
            // circle2.Display(); compile error
        }
    }
}
