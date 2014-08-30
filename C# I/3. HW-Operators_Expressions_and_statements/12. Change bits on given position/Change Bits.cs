using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12.ChangeBitOnGivenPossition
{
    class ChangeBits
    {
        static void Main()
        {
            byte value, p;
            int n;
            Console.Write("Enter the integer number n:");
            bool isnInt = int.TryParse(Console.ReadLine(), out n);
            Console.Write("Enter the value of the bit:");
            bool isValueByte = byte.TryParse(Console.ReadLine(), out value);
            Console.Write("Enter the position of the bit p:");
            bool ispByte = byte.TryParse(Console.ReadLine(), out p);

            if (isnInt && isValueByte && ispByte && value < 2 && p < 32)
            {

                int mask = 1 << p;
                if (value == 1)
                {
                    n = n | mask;
                }
                else
                {
                    if ((n & mask) == mask)
                    {
                        n = n ^ mask;
                    }
                }
                Console.WriteLine("n={0}", n);
            }
            else
            {
                Console.WriteLine("Not a valid entry!");
            }
        }
    }
}