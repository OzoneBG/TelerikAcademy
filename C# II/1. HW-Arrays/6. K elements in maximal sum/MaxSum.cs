using System;
    //Write a program that reads two integer numbers N and K and an array of N elements from the console. 
    //Find in the array those K elements that have maximal sum.

    class MaxSum
    {
        static void Main()
        {
            //Input and vars
            Console.Write("Input N: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Input K: ");
            int K = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            int sum = 0;

            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(Console.ReadLine()); 
            }

            //Do stuff
            if (K > N)
            {
                Console.WriteLine("N must be bigger than K"); 
            }

            Array.Sort(array);

            for (int i = N - 1; i >= N - K; i--)
            {
                sum += array[i];
            }


            //Output
            Console.WriteLine("Total sum: {0}", sum);


        }
    }

