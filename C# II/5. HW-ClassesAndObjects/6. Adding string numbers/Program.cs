﻿using System;

//You are given a sequence of positive integer value
//s written into a string, separated by spaces. Write a
//function that reads these values from given string
//and calculates their sum. Example:
//		string = "43 68 9 23 318"  result = 461


    class Program
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' ');
            int result = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                result += Convert.ToInt32(numbers[i]);
            }

            Console.WriteLine(result);
        }
    }
