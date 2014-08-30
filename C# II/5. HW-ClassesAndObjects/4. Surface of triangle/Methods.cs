using System;

namespace Triangle
{
    class Methods
    {
        public double BaseAndHeight(double Base, double Height)
        {
            double area = (Base * Height) / 2;
            return area;
        }

        public double TreeSides(double a, double b, double c)
        {
            double area = (a + b + c) / 2;

            return area;
        }

        public double TwoSidesAndAngle(double b, double c, double alpha)
        {
            return (b * c * Math.Sin(Math.PI * alpha / 180)) / 2;
        }
    }
}
