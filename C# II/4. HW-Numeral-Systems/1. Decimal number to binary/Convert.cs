using System;

//Write a program to convert decimal numbers to their
//binary representation

    class Converting
    {
        static void Main()
        {
            //Input
            Console.Write("Input your decimal: ");
            int num = int.Parse(Console.ReadLine());

            //Convert
            string binary = Convert.ToString(num, 2);

            //Output
            Console.WriteLine("Decimal to binary: {0}", binary);
        }
    }
