using System;

namespace ShapeLibrary
{
    public class Square : Shape
    {
        public override void SetLocation(Point p)
        {
            Console.WriteLine($"{this} - {nameof(SetLocation)}");
        }

        public override Point GetLocation()
        {
            Console.WriteLine($"{this} - {nameof(GetLocation)}");
            return new Point();
        }

        public override void SetColor(Color rbg)
        {
            Console.WriteLine($"{this} - {nameof(SetColor)}");
        }

        public override void Fill()
        {
            Console.WriteLine($"{this} - {nameof(Fill)}");
        }

        public override void Display()
        {
            Console.WriteLine($"{this} - {nameof(Display)}");
        }

        public override void UnDisplay()
        {
            Console.WriteLine($"{this} - {nameof(UnDisplay)}");
        }

        public override double Area
        {
            get { return 50; }
        }
    }
}
