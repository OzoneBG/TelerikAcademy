using System;

//Write a method that counts how many times given
//number appears in given array. Write a test program
//to check if the method is working correctly.


    class Program
    {
        //Methods
        static void GivenNumber(int num, int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num)
                {
                    count++;
                }
            }

            Console.WriteLine("Number {0} appears {1} times", num, count);
        }

        static void Main()
        {
            //Input and varibles
            Console.Write("Input array length: ");
            int length = int.Parse(Console.ReadLine());
            int[] array =  new int[length];


            for (int i = 0; i < length; i++)
            {
                Console.Write("[{0}]: ", i);
                array[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Input number: ");
            int number = int.Parse(Console.ReadLine());

            //Using the method
            GivenNumber(number, array);
        }

    }

