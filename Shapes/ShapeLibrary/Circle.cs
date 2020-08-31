using System;
using XShapeLibrary;

namespace ShapeLibrary
{
    public class Circle : XCircle, IShape
    {
        public void SetLocation(Point p)
        {
            Console.WriteLine($"{this} - {nameof(SetLocation)}");
        }

        public Point GetLocation()
        {
            Console.WriteLine($"{this} - {nameof(GetLocation)}");
            return new Point();
        }

        public void SetColor(Color rbg)
        {
            Console.WriteLine($"{this} - {nameof(SetColor)}");
        }

        public void Fill()
        {
            Console.WriteLine($"{this} - {nameof(Fill)}");
        }

        public void Display()
        {
            // we do not care about any other methods than XDisplay
            XDisplay(); // using base class
        }

        public void UnDisplay()
        {
            Console.WriteLine($"{this} - {nameof(UnDisplay)}");
        }
    }
}
