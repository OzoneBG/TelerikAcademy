using System;

//Write a program to convert binary numbers to
//hexadecimal numbers (directly).


    class Converting
    {
        static string BinaryToHex(string binary)
        {
            string hex = Convert.ToInt32(binary, 2).ToString("X");
            return hex;
        }

        static void Main()
        {
            //Input
            Console.Write("Input your binary: ");
            string binary = Console.ReadLine();

            //Convert
            string hex = BinaryToHex(binary);

            Console.WriteLine("Binary to hex: {0}", hex);
        }
    }
