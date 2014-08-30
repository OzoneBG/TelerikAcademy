using System;
using System.Linq;
using System.Collections.Generic;

//Write a program that finds the most frequent number in an array. Example:
//{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)


    class MostFrequent
    {
        static void Main()
        {
            //Input and variables
            Console.Write("What is the array length? => ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            int repeats = 0;
            int index = 0;

            for (int i = 0; i < length; i++)
            {
                Console.Write("[{0}]: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }


            //Find out the most frequent number
            Dictionary<int, int> elementsInArray = new Dictionary<int, int>();

            for (int i = 0; i < length; i++)
            {
                if (elementsInArray.ContainsKey(array[i]))
                {
                    elementsInArray[array[i]] += 1;
                }
                else
                {
                    elementsInArray.Add(array[i], 1);
                }
            }


            //Output
            int number = elementsInArray.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            int count = elementsInArray.Max(x => x.Value);

            Console.WriteLine("{0} ({1} times)", number, count);
        }
    }

