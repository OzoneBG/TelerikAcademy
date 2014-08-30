using System;

    //Write a program that compares two char arrays lexicographically (letter by letter).

    class Compare
    {
        static void Main()
        {
            //Declare variables & arrays
            Console.Write("What is the length of the char arrays? ");
            int arraySize = int.Parse(Console.ReadLine());

            char[] array1 = new char[arraySize];
            char[] array2 = new char[arraySize];

            //Assign number for first array
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write("Array 1 [{0}]: ", i);
                array1[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine();

            //Assign numbers for second array

            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write("Array 2 [{0}]: ", i);
                array2[i] = char.Parse(Console.ReadLine());
            }

            //Compare and output them
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] > array2[i])
                {
                    Console.WriteLine("{0} is lexicographically bigger than {1}", array1[i], array2[i]);
                }
                else if (array2[i] > array1[i])
                {
                    Console.WriteLine("{1} is lexicographically bigger than {0}", array1[i], array2[i]);
                }
                
            }
        }
    }

