using System;
using System.Globalization;
using System.Threading;

class FindSign
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        float aNum, bNum, cNum;
        Console.WriteLine("Input three real numbers with either DOT or COMMA for decimal separator!");
        bool test = float.TryParse(Console.ReadLine().Replace(',', '.'), out aNum);
        test &= float.TryParse(Console.ReadLine().Replace(',', '.'), out bNum);
        test &= float.TryParse(Console.ReadLine().Replace(',', '.'), out cNum);
        if (test)
        {
            if (aNum == 0 || bNum == 0 || cNum == 0)
            {
                Console.WriteLine("The product of the numbers is zero!");
            }
            else
            {
                bool positive = true;
                if (aNum < 0)
                {
                    positive = !positive;
                }
                if (bNum < 0)
                {
                    positive = !positive;
                }
                if (cNum < 0)
                {
                    positive = !positive;
                }
                Console.WriteLine("The product of the numbers is {0}!", positive ? "positive" : "negative");
            }
        }
        else
        {
            Console.WriteLine("You have inputed incorrect data!");
        }
    }
}