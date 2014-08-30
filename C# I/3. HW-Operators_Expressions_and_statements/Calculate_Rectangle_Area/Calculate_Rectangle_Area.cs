using System;

namespace Calculate_Rectangle_Area
{
    class RectangleArea
    {
        static void Main()
        {
            float width, height, area;

            Console.Write("Input rectangle's width: ");
            width = float.Parse(Console.ReadLine());
            Console.Write("Input rectangle's height: ");
            height = float.Parse(Console.ReadLine());

            area = (width * 2) + (height * 2);

            Console.WriteLine("Rectangle's area is: {0}", area);
        }
    }
}
