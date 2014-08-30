using System;

//Write a method GetMax() with two parameters that
//returns the bigger of two integers. Write a program
//that reads 3 integers from the console and prints the
//biggest of them using the method GetMax().


    class GetMax
    {
        //Our methods
        static void GetMaxOfTwo(int A, int B)
        {
            if (A > B)
            {
                Console.WriteLine("First: ({0}) is bigger than the second: ({1})", A, B);
            }
            else
            {
                Console.WriteLine("Second: ({0}) is bigger than the first: ({1})", B, A);
            }
        }

        static void GetMaxOfThree(int A, int B, int C)
        {
            if (A > B && A > C)
            {
                Console.WriteLine("First: ({0}) is bigger than the second: ({1}) and the third: ({2})", A, B, C);
            }
            else if (B > A && B > C)
            {
                Console.WriteLine("Second: ({0}) is bigger than the first: ({1}) and the third: ({2})", B, A, C);
            }
            else
            {
                Console.WriteLine("Third: ({0}) is bigger than the first: ({1}) and the second: ({2})", C, A, B);
            }
        }

        static void Main()
        {

            //Input and variables
            Console.WriteLine("Hello, please input three numbers to compare them.");

            Console.Write("First: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Second: ");
            int second = int.Parse(Console.ReadLine());
            Console.Write("Third: ");
            int third = int.Parse(Console.ReadLine());

            //Compare them
            Console.WriteLine("I compared the first two: ");
            GetMaxOfTwo(first, second);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Now, I compared all of them");
            GetMaxOfThree(first, second, third);
        }
    }

