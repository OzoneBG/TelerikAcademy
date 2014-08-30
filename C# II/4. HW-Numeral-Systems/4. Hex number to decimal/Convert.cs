using System;

//Write a program to convert hexadecimal numbers to their
//decimal representation.

    class Converting
    {
        static void Main()
        {
            //Input
            Console.Write("Input your hex: ");
            string hex = Console.ReadLine();

            //Convert
            int dec = int.Parse(hex, System.Globalization.NumberStyles.HexNumber);

            //Output
            Console.WriteLine("Hex to decimal: {0}", dec);
        }
    }

