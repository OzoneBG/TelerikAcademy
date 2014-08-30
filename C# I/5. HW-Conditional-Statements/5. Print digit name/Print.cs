using System;

namespace _5.Print_digit_name
{
    class Print
    {
        static void Main()
        {
            //Declare variables
            byte digit;
            string digitName = "";
            //Assign values
            Console.Write("Enter a digit (0 to 9): ");
            digit = byte.Parse(Console.ReadLine());

            //Check digit
            switch (digit)
            {
                case 0:
                    digitName = "Zero";
                    break;
                case 1:
                    digitName = "One";
                    break;
                case 2:
                    digitName = "Two";
                    break;
                case 3:
                    digitName = "Three";
                    break;
                case 4:
                    digitName = "Four";
                    break;
                case 5:
                    digitName = "Five";
                    break;
                case 6:
                    digitName = "Six";
                    break;
                case 7:
                    digitName = "Seven";
                    break;
                case 8:
                    digitName = "Eight";
                    break;
                case 9:
                    digitName = "Nine";
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
            
            //Output it
            Console.WriteLine(digitName);
        }
    }
}
