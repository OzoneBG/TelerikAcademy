using System;

namespace _10.Has_value_of_1
{
    class Check
    {
        static void Main(string[] args)
        {
            int v = 5;
            int p = 1;

            int mask = 1 << p;

            int nAndMask = v & mask;

            int bit = nAndMask >> p;

            if (bit == 1)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

        }
    }
}
