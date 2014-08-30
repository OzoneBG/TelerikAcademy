using System;

namespace Bat_Goiko
{
    class Program
    {
        static void Main()
        {
            int H = int.Parse(Console.ReadLine());
            int leftDots = H - 1;
            int rightDots = H - 1;
            int n1 = 2;
            int countLine = 2;
          

            //Top
            Console.WriteLine(new string('.', leftDots) + new string('/', 1) + new string('\\', 1) + new string('.', rightDots));

            //Middle
            for (int i = 1; i <= H - 1; i++)
            {
                Console.Write(new string('.', H - n1));
                Console.Write(new string('/', 1));
                if (i == 1 || i == 3 || i == 6 || i == 10 || i == 15 || i == 21 || i == 28 || i == 36)
                {
                    Console.Write(new string('-', i * 2));
                }
                else
                {
                    Console.Write(new string('.', i * 2));
                }
                
                Console.Write(new string('\\', 1));
                Console.Write(new string('.', H - n1));
                Console.WriteLine();
                n1++;
            }
            
        }
    }
}
