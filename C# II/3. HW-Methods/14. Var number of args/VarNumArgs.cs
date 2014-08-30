using System;

//Write methods to calculate minimum, maximum,
//average, sum and product of given set of integer
//numbers. Use variable number of arguments.

namespace VarNumArgs
{
    class VarNumArgs
    {
        static void Main()
        {
            Methods Method = new Methods();

            int min = Method.Min(9, 6, 3);
            int max = Method.Max(9, 6, 3);
            int avg = Method.Average(9, 6, 3);
            int sum = Method.Sum(9, 6, 3);
            int product = Method.Product(9, 6, 3);

            Console.WriteLine("Minimum: {0}", min);
            Console.WriteLine("Maximum: {0}", max);
            Console.WriteLine("Average: {0}", avg);
            Console.WriteLine("Sum: {0}", sum);
            Console.WriteLine("Product: {0}", product);
        }
    }
}
