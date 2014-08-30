using System;

//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
		//Create appropriate methods.
		//Provide a simple text-based menu for the user to choose which task to solve.
		//Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

namespace Multitask
{
    class Multitask
    {
        static void Main()
        {
            Methods Methods = new Methods();

            Console.WriteLine("What's your name?");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Methods.SayHello(name);
            Console.WriteLine("Choose what do you want to do:");
            Console.WriteLine("1. Press \"R\" to reverse digits of a number");
            Console.WriteLine("2. Press \"A\" to calculate the average of a sequence of ints");
            Console.WriteLine("3. Press \"S\" to solve a linear equation");

            char option = char.Parse(Console.ReadLine());

            if (option == 'R' || option == 'r')
            {
                Console.Write("Input your number: ");
                string number = Console.ReadLine();

                Console.Write("Reversed {0} will be: ", number);
                Methods.ReverseDigits(number);

            }
            else if (option == 'A' || option == 'a')
            {
                Console.Write("Input how many ints do you want to calculate average: ");
                int length = int.Parse(Console.ReadLine());
                int[] array = new int[length];

                for (int i = 0; i < length; i++)
                {
                    Console.Write("[{0}]", i + 1);
                    array[i] = int.Parse(Console.ReadLine());
                }

                int average = Methods.CalculateAverageOfInts(array);

                Console.WriteLine("Average of your chosen ints is: {0}", average);
                
            }
            else if (option == 'S' || option == 's')
            {
                Console.Write("Input your a: ");
                decimal a = decimal.Parse(Console.ReadLine());

                if (a == 0)
                {
                    Console.WriteLine("WARNING! a cannot be equal to 0");
                }
                
                Console.Write("Input your b: ");
                decimal b = decimal.Parse(Console.ReadLine());
                

                

                if (a < 0 && b < 0)
                {
                    Console.WriteLine("a and b are negative numbers");
                }
                else if (a < 0)
                {
                    Console.WriteLine("a is negative number");
                }
                else if (b < 0)
                {
                    Console.WriteLine("b is negative number");
                }
                else
                {
                    int result = Methods.SolveLinearEquation(a, b);
                    Console.WriteLine("{0} * x + {1} = 0", a, b);
                    Console.WriteLine("x = {0}", result);
                }
     
            }
            else
            {
                Console.WriteLine("You did not select the right option!");
                Console.WriteLine("Please restart the program.");
            }
        }
    }
}

