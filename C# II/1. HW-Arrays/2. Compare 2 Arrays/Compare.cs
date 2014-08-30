using System;

    //Write a program that reads two arrays from the console and compares them element by element.


    class Compare
    {
        static void Main()
        {

            //Declare variables & arrays
            Console.Write("What is the length of the arrays? ");
            int arraySize = int.Parse(Console.ReadLine());

            int[] array1 = new int[arraySize];
            int[] array2 = new int[arraySize];

            //Assign numbers for first array

            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write("Array 1 [{0}]: ", i);
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine();

            //Assign numbers for second array

            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write("Array 2 [{0}]: ", i);
                array2[i] = int.Parse(Console.ReadLine());
            }

            //Compare them and output
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == array2[i])
                {
                    Console.WriteLine("The both elements are equal: [{0}] = [{1}]", array1[i], array2[i]);
                }
                else if (array1[i] > array2[i])
                {
                    Console.WriteLine("The element in the first array is bigger: [{0}] > [{1}]", array1[i], array2[i]);
                }
                else if (array1[i] < array2[i])
                {
                    Console.WriteLine("The element in the second array is bigger: [{0}] < [{1}]", array1[i], array2[i]);
                }
            }

        }
    }

