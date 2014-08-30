using System;

namespace _1.Examine_two_integers
{
    class Examine
    {
        static void Main()
        {
            //Declare variables
            int first, second, exchange = new int();

            //Read values for ints
            Console.Write("First integer: ");
            first = int.Parse(Console.ReadLine());

            Console.Write("Second integer: ");
            second = int.Parse(Console.ReadLine());

            if (first > second)
            {
                exchange = first;
                first = second;
                second = exchange;
            }

            Console.WriteLine("Exchanged values first: {0} and second: {1}", first, second);
        }
    }
}
