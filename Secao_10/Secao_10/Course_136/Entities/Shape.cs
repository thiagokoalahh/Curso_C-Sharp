using Course_136.Entities.Enums;
using System;

namespace Course_136.Entities
{
    abstract class Shape
    {
        public Color Color { get; private set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
