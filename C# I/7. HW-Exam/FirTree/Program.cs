using System;

namespace FirTree
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int star = 1;
            int leftDots = n - 2;
            int rightDots = n - 2;

            string firstLine = new string('.', leftDots) + new string('*', star) + new string('.', rightDots);

            for (int i = 0; i < n-1; i++)
            {
                Console.Write(new string('.', leftDots));
                Console.Write(new string('*', star));
                Console.Write(new string('.', rightDots));
                Console.WriteLine();
                leftDots--;
                rightDots--;
                star += 2;
            }

            Console.WriteLine(firstLine);

        }
    }
}
