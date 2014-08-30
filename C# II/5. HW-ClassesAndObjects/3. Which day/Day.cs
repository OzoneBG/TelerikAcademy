using System;

//Write a program that prints to the console which day
//of the week is today. Use System.DateTime.

    class WhichDay
    {
        static void Main()
        {
            DateTime current = DateTime.Now;

            Console.WriteLine("Current day of the week is: {0}", current.DayOfWeek);
        }
    }

