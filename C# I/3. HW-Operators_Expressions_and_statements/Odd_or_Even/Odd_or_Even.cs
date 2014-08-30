using System;

namespace Odd_or_Even
{
    class OddOrEven
    {
        static void Main()
        {
            int x = 21;

            if (21 % 5 == 0)
            {
                Console.WriteLine("{0} is even number", x);
            }
            else
            {
                Console.WriteLine("{0} is odd number", x);
            }
        }
    }
}
