using System;

namespace _7.Get_numbers_from_n_and_ouput_their_sum
{
    class SumN
    {
        static void Main()
        {
            //Declare variables
            int n;
            int sum = new int();
            int number;

            Console.Write("Input value for n: ");
            n = int.Parse(Console.ReadLine());

            sum += n;

            for (int i = 0; i < 10000000; i++)
            {
                Console.Write("Input next n ");
                number = int.Parse(Console.ReadLine());
                sum += number;
                Console.WriteLine("The sum of n numbers is: {0}", sum);
            }
        }
    }
}
