// Write a program that finds the maximal sequence of equal elements in an array.
//		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

using System;



class Program
{

    static void Main()
    {
        //Input and variables
        Console.Write("What is the array length? => ");
        int length = int.Parse(Console.ReadLine());
        int[] arr = new int[length];
        int len = 1;
        int start = 0;
        int bestStart = 0;
        int bestLen = 1;

        for (int i = 0; i < length; i++)
        {
            Console.Write("[{0}]: ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        //Check max sequence
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                len++;
                if (len == 2)
                {
                    start = i;
                }
                if (len > bestLen)
                {
                    bestLen = len;
                    bestStart = start;
                }
            }
            else
            {

            }
        }

        for (int i = bestStart; i < bestLen + bestStart; i++)
        {
            Console.Write("{0},", arr[i]);
        }
    }
}

