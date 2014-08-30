using System;

namespace _3.The_biggest_of_3_ints
{
    class Find
    {
        static void Main()
        {
            //Declare variables
            int first, second, third;

            //Assign values
            Console.Write("First integer: ");
            first = int.Parse(Console.ReadLine());

            Console.Write("Second integer: ");
            second = int.Parse(Console.ReadLine());

            Console.Write("Third integer: ");
            third = int.Parse(Console.ReadLine());

            if (first > second && first > third)
            {
                Console.WriteLine("The bigger integer is: {0}", first);
            }
            else if (second > first && second > third)
            {
                Console.WriteLine("The bigger integer is: {0}", second);
            }
            else
            {
                Console.WriteLine("The bigger integer is: {0}", third);
            }
        }
    }
}
