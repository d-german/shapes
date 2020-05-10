namespace ShapeLibrary
{
    public interface IShape
    {
        void SetLocation(Point p);
        Point GetLocation();
        void SetColor(Color rbg);
        void Fill();
        void Display();
        void UnDisplay();
    }
}
