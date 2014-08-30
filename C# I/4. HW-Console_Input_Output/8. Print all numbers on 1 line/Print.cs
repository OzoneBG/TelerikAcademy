using System;

class PrintAllNumbersInInterval
{
    static void Main()
    {
        int firstIntervalNumber = 1;
        Console.Write("Enter end interval number(>0) = ");
        string strEndIntevalNumber = Console.ReadLine();
        int endIntervalNumber;
        bool endIntervalNumberSuccess = int.TryParse(strEndIntevalNumber, out endIntervalNumber);
        if (endIntervalNumberSuccess == true && endIntervalNumber > 0)
        {
            Console.WriteLine("Numbers in interval [{0},{1}] are: ", firstIntervalNumber, endIntervalNumber);
            for (int i = 1; i <= endIntervalNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            Console.WriteLine("You entered wrong input! Please Try Again!");
            Main();
        }
    }
}
