using System;

//Write a program that reads a year from the console
//and checks whether it is a leap. Use DateTime.

    class LeapYear
    {
        static void Main()
        {
            Console.Write("Input a year: ");
            int year = int.Parse(Console.ReadLine());

            bool isLeap = DateTime.IsLeapYear(year);

            if (isLeap == true)
            {
                Console.WriteLine("The year is leap!");
            }
            else
            {
                Console.WriteLine("The year isn't leap!");
            }
        }
    }

