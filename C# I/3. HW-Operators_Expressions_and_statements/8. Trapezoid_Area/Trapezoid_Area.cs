using System;

namespace Trapezoid_Area
{
    class Trapezoid
    {
        static void Main()
        {
            double a, b, h, area;

            Console.Write("Input number for a: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Input number for b: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Input number for h: ");
            h = double.Parse(Console.ReadLine());

            area = (a + b) * 0.5 * h;

            Console.WriteLine("Trapezoid's area is: {0}", area);
        }
    }
}
