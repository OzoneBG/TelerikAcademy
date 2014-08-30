using System;

namespace VarNumArgs
{
    class Methods
    {
        //Minimum
        public int Min(params int[] seq)
        {
            int min = seq[0];

            for (int i = 0; i < seq.Length; i++)
            {
                if (seq[i] < min)
                {
                    min = seq[i];
                }
            }

            return min;
        }

        //Maximum
        public int Max(params int[] seq)
        {
            int max = seq[0];

            for (int i = 0; i < seq.Length; i++)
            {
                if (seq[i] > max)
                {
                    max = seq[i];
                }
            }

            return max;
        }

        //Average
        public int Average(params int[] seq)
        {
            int result = 0;

            for (int i = 0; i < seq.Length; i++)
            {
                result += seq[i];
            }

            result /= seq.Length;

            return result;
        }

        //Sum
        public int Sum(params int[] seq)
        {
            int result = 0;

            for (int i = 0; i < seq.Length; i++)
            {
                result += seq[i];
            }

            return result;
        }

        //Product
        public int Product(params int[] seq)
        {
            if (seq.GetLength(0) > 0)
            {
                int product = 1;
                foreach (int x in seq)
                {
                    product *= x;
                }

                return product;
            }
            else
            {
                return 0;
            }
        }
    }
}
