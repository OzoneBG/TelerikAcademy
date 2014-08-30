using System;

//Write a program that finds the maximal increasing sequence in an array. Example: 
//{3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.


    class Sequence
    {
        static void Main()
        {
            //Input and variables
            Console.Write("What is the array length? => ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            int len = 0;
            int start = 0;
            int bestLen = 1;
            int bestStart = 0;

            for (int i = 0; i < length; i++)
            {
                Console.Write("[{0}]: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            //Check max increase sequence
            for (int i = 0; i < length - 1; i++)
            {
                if (array[i] < array[i+1])
                {
                    if (array[i+1] - array[i] == 1)
                    {
                        len++;
                    }
                        
                    if(len == 2)
                    {
                        start = i - 1;
                    }

                    if (len > bestLen)
                    {
                        bestLen = len;
                        bestStart = start;
                    }
                }
            }

            //Output
            for (int i = bestStart; i < bestStart + bestLen + 1 ; i++)
            {
                Console.Write("{0}, ", array[i]);
            }

        }
    }

