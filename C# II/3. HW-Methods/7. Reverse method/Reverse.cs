using System;

//Write a method that reverses the digits of given
//decimal number. Example: 256  652


    class Reverse
    {
        //Method
        static void ReverseDigits(string digits)
        {
            char[] temp = new char[digits.Length];
            int someCount = 0;

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (true)
                {
                    temp[someCount] = digits[i];
                    someCount++;
                }
            }

            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write("{0}", temp[i]);
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        static void Main()
        {
            //Input and variables
            Console.Write("Input your digits to reverse them: ");
            string digits = Console.ReadLine();

            ReverseDigits(digits);
        }
    }
