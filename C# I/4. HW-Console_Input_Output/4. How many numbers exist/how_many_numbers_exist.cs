using System;

namespace _4.How_many_numbers_exist
{
    class HowMany
    {
        static void Main()
        {
            //Declare variables
            int a, b; //First "a" number and second "b" number
            int p = 0; //How many numbers

            //Read first number "a"
            Console.Write("Input your first number: ");
            a = int.Parse(Console.ReadLine());

            //Read second number "b"
            Console.Write("Input your second number: ");
            b = int.Parse(Console.ReadLine());


            //Find the how many number exist betwen "a" and "b"
            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0)
                {
                    p++;
                }
            }

            //Output them
            Console.WriteLine(p);
        }
    }
}
