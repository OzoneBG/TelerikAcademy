using System;

namespace OOP_Principles_II
{
    class IO
    {
        static void Main()
        {
            Shape[] array = {
                             new Circle(2),
                             new Rectangle(2, 3),
                             new Triangle(2, 3)
                            };

            foreach (var shape in array)
            {
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}
