using System;

//Write a program to convert binary numbers to their
//decimal representation.

    class Converting
    {
        static void Main()
        {
            //Input
            Console.Write("Input your binary: ");
            string binary = Console.ReadLine();

            string decim = Convert.ToInt32(binary, 2).ToString();

            Console.WriteLine("Binary number to decimal: {0}", decim);


        }
    }

