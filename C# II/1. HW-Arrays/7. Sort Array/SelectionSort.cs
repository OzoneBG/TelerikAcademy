using System;

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the "selection sort" algorithm: Find the smallest element, move it at the first position, 
//find the smallest from the rest, move it at the second position, etc.


    class SelectionSort
    {
        static void Main()
        {
            //Input and variables
            Console.Write("What is the array length? => ");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("[{0}]: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            //Sort the array
            Array.Sort(arr);

            //Output it
            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
    }

