using System;

namespace ShapeLibrary
{
    public abstract class Shape
    {
        private static int _id = 0;

        /// <summary>
        /// Note it is good practice to declare this protected instead of public
        /// </summary>
        protected Shape()
        {
            _id++;
        }

        public abstract void SetLocation(Point p);
        public abstract Point GetLocation();
        public abstract void SetColor(Color rbg);
        public abstract void Fill();

        public virtual void Fill(Color rbg)
        {
            Console.WriteLine($"Filling shape with {rbg}");
        }

        public abstract void Display();
        public abstract void UnDisplay();

        public abstract double Area { get; } // readonly

        public override string ToString()
        {
            return $"{GetType()} #{_id} ";
        }
    }
}
