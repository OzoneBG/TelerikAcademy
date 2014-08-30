using System;

namespace OOP_Principles_II
{
    class Triangle : Shape
    {
        public Triangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double CalculateSurface()
        {
            double surface = new double();
            surface = this.height * this.width;
            surface /= 2;
            return surface;
        }
    }
}
