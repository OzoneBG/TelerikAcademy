using System;

//Write a method that returns the index of the first
//element in array that is bigger than its neighbors, or
//-1, if there’s no such element.
//Use the method from the previous exercise.


    class FirstIndex
    {
        //Methods
        static int CheckElement(int[] array, int element)
        {
            if (array[element] > array[element + 1] && array[element] > array[element - 1])
            {
                return element;
            }
            else
            {
                return -1;
            }
            
        }


        static void Main()
        {
            //Input and variables
            Console.Write("Input array length: ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            int index = -1;
            int count = 0;

            for (int i = 0; i < length; i++)
            {
                Console.Write("[{0}]", i);
                array[i] = int.Parse(Console.ReadLine());
                
            }

            //Finding the first index
            for (int i = 1; i < length - 1; i++)
            {
                
                index = CheckElement(array, i);
                if (index > -1)
                {
                    count++;
                }

                if (count == 1)
                {
                    break;
                }
            }

            //Ouput
            Console.WriteLine("The first element that is bigger than it's neighbours is: {0}", index);
        }
    }

