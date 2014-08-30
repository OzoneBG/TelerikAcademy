using System;


namespace Is_within_a_circle
{
    class WithinCircle
    {
        static void Main()
        {
            float x, y;

            Console.Write("Input value for x: ");
            x = float.Parse(Console.ReadLine());
            Console.Write("Input value for y: ");
            y = float.Parse(Console.ReadLine());

            if ((x * x) + (y * y) <= 25)
            {
                Console.WriteLine("X: {0} and Y: {1} are within the circle.", x, y);
            }
            else
            {
                Console.WriteLine("Given numbers are not within the circle.");
            }
        }
    }
}
