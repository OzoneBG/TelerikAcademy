using System;

namespace OOP_Principles_II
{
    class Rectangle : Shape
    {
        public Rectangle(double width, double height)
        {
            this.height = height;
            this.width = width;
        }

        public override double CalculateSurface()
        {
            double surface = new double();
            surface = this.height * this.width;
            return surface;
        }
    }
}
