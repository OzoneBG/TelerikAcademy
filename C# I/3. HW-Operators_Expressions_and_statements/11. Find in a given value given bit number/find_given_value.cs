using System;

namespace _11.Find_in_a_given_value_given_bit_number
{
    class Find
    {
        static void Main()
        {
            int value = 0;
            int i;
            byte b;
            Console.Write("Input value for i: ");
            i = int.Parse(Console.ReadLine());
            Console.Write("Input value for p: ");
            b = byte.Parse(Console.ReadLine());

            int mask = 1 << b;
            if ((i & mask) == b)
            {
                value = 1;
            }

            Console.WriteLine("value={0}", value);
        }
    }
}
