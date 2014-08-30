using System;

namespace _2.Print_Circle_area_and_perimeter
{
    class Print
    {
        static void Main()
        {
            //Declare variables
            int r;
            float p = 3.14F, area, perimeter;

            //Ask user to input value for radius
            Console.Write("Input circle's radius: ");
            r = int.Parse(Console.ReadLine());
            
            //Do calculation and output it
            area = p * (r * r);
            perimeter = 2 * (p * r);

            Console.WriteLine("Circle's area is: {0} and perimeter: {1}", area, perimeter);

        }
    }
}
