using System;

namespace _5.Is_bit_1
{
    class IsBit1
    {
        static void Main()
        {
            bool is3Digit1 = false;
            int number;
            Console.Write("Input number: ");
            number = int.Parse(Console.ReadLine());

            if ((number & 8) == 8)
            {
                is3Digit1 = true;
            }

            Console.WriteLine("Is the third digit equal to 1?:{0}", is3Digit1);
        }
    }
}
