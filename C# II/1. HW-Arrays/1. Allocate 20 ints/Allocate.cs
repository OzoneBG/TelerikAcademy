﻿using System;
    class Allocate
    {
        static void Main()
        {
            //Write a program that allocates array of 20 integers 
            //and initializes each element by its index multiplied by 5. 
            //Print the obtained array on the console.

            //Create new array
            int[] array = new int[20];

            //Initialize it
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 5;
            }

            //Output it
            for (int i = 0; i < array.Length; i++)
			{
			    Console.WriteLine(array[i]);
			}

        }
    }
