using System;

namespace _6.Quadratic_equation
{
    class Calculate
    {
        static void Main()
        {
            //Title for console
            Console.Title = "Discriminant";

            //Declare variables
            double a, b, c, discriminant, x1, x2;

            //Assign values for  them
            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());

            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());

            Console.Write("c = ");
            c = double.Parse(Console.ReadLine());

            //Do some checking
            if (a == 0)
            {
                Console.WriteLine("This is not a quadratic equation.");
            }

            //Calculate discriminant
            discriminant = (b * b) - (4 * a * c);
            Console.WriteLine("Discriminant is: {0}", discriminant);

            //Find real roots
            if (discriminant < 0)
            {
                Console.WriteLine("Discriminant {0} doesn't have real roots.", discriminant);
            }
            else if (discriminant == 0)
            {
                Console.WriteLine("Discriminant {0} has only one real root 0", discriminant);
            }
            else
            {
                x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("Discriminant {0} have two real roots x1 = {1} and x2 = {2}", discriminant, x1, x2);
            }
            //Console.WriteLine(discriminant);
        }
    }
}
