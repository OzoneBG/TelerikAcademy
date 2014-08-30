using System;

//Write a program to convert decimal numbers to their
//hexadecimal representation.


    class Converting
    {
        static void Main()
        {
            //Input
            Console.Write("Input your decimal: ");
            int decim = int.Parse(Console.ReadLine());

            //Convert
            string hex = decim.ToString("X"); 

            //Output
            Console.WriteLine("Converted decimal to hex: {0}", hex);

        }
    }

