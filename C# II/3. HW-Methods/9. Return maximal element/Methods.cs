using System;

//Write a method that return the maximal element in
//a portion of array of integers starting at given index.
//Using it write another method that sorts an array in
//ascending / descending order

    class Methods
    {
        //Methods
        static int FindMaxElement(int[] array, int interval)
        {
            int Element = 0;
            int maxNumber = 0;

            for (int i = interval; i < array.Length; i++)
            {
                if (array[i] > maxNumber)
                {
                    maxNumber = array[i];
                    Element = i;
                }
            }

            return Element;
        }

        static void SortArrayAsc(int[] array)
        {
            Array.Sort(array);
            Console.WriteLine("Sorted Ascending: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            
        }

        static void SortArrayDesc(int[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }

        }

        static void Main()
        {
            //Input and variables
            Console.Write("Input in wich interval you want to search: ");
            int interval = int.Parse(Console.ReadLine());
            Console.Write("Input your array length: ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("[{0}]: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            //Finding max element
            int element = FindMaxElement(array, interval);


            Console.WriteLine("The maximal element is {0} with value of {1}",element ,array[element]);

            //Sorting
            //Ascending
            SortArrayAsc(array);

            Console.WriteLine();
            Console.WriteLine();

            //Descending
            SortArrayDesc(array);

            
        }
    }

