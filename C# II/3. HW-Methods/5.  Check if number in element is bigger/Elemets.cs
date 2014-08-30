using System;

//Write a method that checks if the element at given
//position in given array of integers is bigger than its
//two neighbors (when such exist

    class Program
    {
        //Method
        static void CheckElement(int[] array, int element)
        {
            if (element == array.Length - 1)
            {
                if (array[element] > array[array.Length - 2])
                {
                    Console.WriteLine("Your chosen element is bigger than it's neighbour element!");
                }
                else
                {
                    Console.WriteLine("Your chosen element is smaller than it's neighbour element!");
                }
            }
            else if (element == 0)
            {
                if (array[element] > array[1])
                {
                    Console.WriteLine("Your chosen element is bigger than it's neighbour element!");
                }
                else
                {
                    Console.WriteLine("Your chosen element is smaller than it's neighbour element!");
                }
            }
            else
            {
                if (array[element] > array[element + 1] && array[element] > array[element - 1])
                {
                    Console.WriteLine("Your chosen element is bigger than it's neighbour elements!");
                }
                else
                {
                    Console.WriteLine("Your chosen element is smaller than it's neighbour elements!");
                }
            }
        }

        static void Main()
        {
            //Input and variables
            Console.Write("Please, input array's length: ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("[{0}]: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Please, input which element to check: ");
            int element = int.Parse(Console.ReadLine());

            CheckElement(array, element);

        }
    }

