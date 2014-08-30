using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9.IsThePointInTheCircle_OutOfRectange
{
    class IsOutOf
    {
        static void Main()
        {
            bool check = false;
            double X, Y;
            Console.Write("Enter X:");
            bool Xcheck = double.TryParse(Console.ReadLine(), out X);
            Console.Write("Enter Y:");
            bool Ycheck = double.TryParse(Console.ReadLine(), out Y);
            if (Xcheck && Ycheck)
            {
                if ((X >= -1 && Y >= -1) && (X <= 5 && Y <= 1))
                {
                    //Do nothing   
                }
                else
                {
                    double displacedX = X - 1;
                    double displacedY = Y - 1;
                    if ((displacedX * displacedX + displacedY * displacedY) <= 9)
                    {
                        check = true;
                    }
                }
                Console.WriteLine("Is the point ({0},{1}) within the circle and out of the rectangle?:{2}", X, Y, check);
            }
            else
            {
                Console.WriteLine("Not a valid entry!");
            }

        }
    }
}