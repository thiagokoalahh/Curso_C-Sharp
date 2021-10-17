using Course_136.Entities.Enums;
using System;

namespace Course_136.Entities
{
    class Circle : Shape
    {
        public double Radius { get; private set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * (Radius * Radius);
        }
    }
}
