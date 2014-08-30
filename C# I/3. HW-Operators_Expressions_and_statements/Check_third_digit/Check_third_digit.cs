using System;

namespace Check_third_digit
{
    class CheckThirdDigit
    {
        static void Main()
        {
            Console.Write("Input a number: ");
            int number = int.Parse(Console.ReadLine());
            int calc = number / 100;
            int digit = calc % 10;
            if (digit == 7)
            {
                Console.WriteLine("Third digit is: {0}", digit);
            }
            else
            { 
                Console.WriteLine("Third digit is not 7, it is: {0}", digit);
            }
        }
    }
}
