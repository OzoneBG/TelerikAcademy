using System;
using System.Numerics;

//Write a program to calculate n! for each n in the
//range [1..100]. Hint: Implement first a method
//that multiplies a number represented as array of
//digits by given integer number. 


    class Faktoriel
    {
        static void Main()
        {
            //Input and variables
            BigInteger faktoriel = 1;
            Console.Write("Input N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                faktoriel *= i;

                Console.WriteLine("Faktoriel: {0}", faktoriel);
            }
        }
    }

