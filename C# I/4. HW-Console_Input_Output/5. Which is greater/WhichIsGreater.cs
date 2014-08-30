using System;

namespace _5.Which_is_greater
{
    class Greater
    {
        static void Main()
        {
            //Declare variables
            int a, b, greater;
            

            //Assign variables from console
            Console.Write("Input first number: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Input second number: ");
            b = int.Parse(Console.ReadLine());

            //Check which is greater
            greater = Math.Max(a, b);

            //Output it
            Console.WriteLine("The greater number is: {0}", greater);
        }
    }
}
