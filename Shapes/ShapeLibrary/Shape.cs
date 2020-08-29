using System;

namespace ShapeLibrary
{
    public abstract class Shape
    {
        private static int _id = 0;

        protected Shape()
        {
            _id++;
        }

        public abstract void SetLocation(Point p);
        public abstract Point GetLocation();
        public abstract void SetColor(Color rbg);
        public abstract void Fill();
        public abstract void Display(); //TODO: make this a virtual example with Console.WriteLine();
        public abstract void UnDisplay();

        public override string ToString()
        {
            return $"{GetType()} #{_id} ";
        }
    }
}
