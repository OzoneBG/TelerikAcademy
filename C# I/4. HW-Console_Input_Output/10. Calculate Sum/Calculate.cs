using System;

class CalculateSum
{
    static void Main()
    {
        float result = 1, tempSum = 1;
        int divisor = 2;

        while (tempSum > 0.001f)
        {
            tempSum /= 2;

            if (divisor % 2 == 0)
            {
                result += tempSum;
            }
            else
            {
                result -= tempSum;
            }

            divisor++;
        }

        Console.WriteLine(result);
    }
}
