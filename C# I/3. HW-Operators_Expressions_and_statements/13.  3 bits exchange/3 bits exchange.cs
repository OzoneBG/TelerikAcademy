using System;

namespace _13._3BitsExchange
{
    class Exchange
    {
        static void Main()
        {
            uint n;
            Console.Write("Enter the unsigned integer number n:");
            bool isnInt = uint.TryParse(Console.ReadLine(), out n);
            if (isnInt)
            {
                Console.WriteLine("binary initial n:");
                Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));

                n = ((~(7u << 24 | 7u << 3)) & n) | (((n & (7u << 3)) << 21) | ((n & (7u << 24)) >> 21));//Swap bits 3,4,5 with 24,26,26

                Console.WriteLine("binary new n:");
                Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
            }
            else
            {
                Console.WriteLine("Not a valid entry!");
            }
        }
    }
}