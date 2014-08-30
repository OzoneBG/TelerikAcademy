using System;

//Write a program to convert hexadecimal numbers to
//binary numbers (directly).


    class Converting
    {
        static string HexToBinary(string hex)
        {
            string binary = Convert.ToString(Convert.ToInt32(hex, 16), 2);
            return binary;
        }

        static void Main()
        {
            //Input
            Console.Write("Input your hex: ");
            string hex = Console.ReadLine();

            string binary = HexToBinary(hex);

            Console.WriteLine("Hex to binary: {0}", binary);

        }
    }
