using System;

namespace _1.Read_3_integers
{
    class Read
    {
        static void Main()
        {
            //Declare variables
            int x, y, z, sum;

            //Ask user to input values
            Console.Write("Input value for x: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Input value for y: ");
            y = int.Parse(Console.ReadLine());

            Console.Write("Input value for z: ");
            z = int.Parse(Console.ReadLine());
            
            //Do the suming and output it
            sum = x + y + z;
            Console.WriteLine();

            Console.WriteLine("The sum of {0}, {1} and {2} is : {3} ", x, y, z, sum );
        }
    }
}
