using Course_136.Entities.Enums;

namespace Course_136.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; private set; }
        public double Height { get; private set; }

        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
