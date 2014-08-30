using System;

namespace OOP_Principles_II
{
    class Circle : Shape
    {
        public Circle(double radius)
        {
            this.width = radius;
        }

        public override double CalculateSurface()
        {
            double surface = new double();
            surface = Math.PI * this.width * 2;
            return surface;
        }
    }
}
