using System;

//Write a program that finds the sequence of maximal sum in given array. Example:
//{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
//Can you do it with only one loop (with single scan 
//through the elements of the array)?



    class MaxSum
    {
        static void Main()
        {
            //Input and variables
            Console.Write("What is the array length? => ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            int max = array[0], maxEnd = array[0];
            int longSequence = 1, currentSequence = 1;
            int start = 0, startTemp = 0;

            for (int i = 0; i < length; i++)
            {
                Console.Write("[{0}]: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }


            //Kadane's algorithm
            for (int i = 0; i < length; i++)
            {
                if (array[i] + maxEnd > array[i])
                {
                    maxEnd = array[i] + maxEnd;
                    currentSequence++;
                }
                else
                {
                    maxEnd = array[i];
                    startTemp = i;
                    currentSequence = 1;
                }

                if (maxEnd > max)
                {
                    max = maxEnd;
                    longSequence = currentSequence;
                    start = startTemp;
                }
            }

            //Output
            for (int i = start; i < start + longSequence; i++)
            {
                Console.Write("{0}, ", array[i]);
            }
        }
    }

