using System;
namespace Multitask
{
    class Methods
    {
        //Methods on topic

        //Task Methods
        //Reverse digits of a number
        public void ReverseDigits(string digits)
        {
            char[] temp = new char[digits.Length];
            int someCount = 0;

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (true)
                {
                    temp[someCount] = digits[i];
                    someCount++;
                }
            }

            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write("{0}", temp[i]);
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        //Calculate the average of a sequence of integers
        public int CalculateAverageOfInts(int[] integers)
        {
            int average = 0;

            for (int i = 0; i < integers.Length; i++)
            {
                average += integers[i];
            }

            average /= integers.Length;

            return average;
        }

        //Solving linear equation -> a * x + b = 0
        public int SolveLinearEquation(decimal a, decimal b)
        {
            decimal x;
            b = b * -1;

            x = b / a;

            int X = Convert.ToInt32(x);

            return X;
        }

        //Off-topic methods

        //Greet user method
        public void SayHello(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
