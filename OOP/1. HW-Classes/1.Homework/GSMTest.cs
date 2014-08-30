using System;

namespace Homework
{
    class GSMTest
    {
        static void Main()
        {
            //Create array
            GSM[] array = new GSM[4];

            //Instances of GSM
            GSM firstGSM = new GSM("Galaxy S4", "Samsung", 1000.0, "Nasko");
            GSM secondGSM = new GSM("6303", "Nokia", 300.0, "Dinko");
            GSM thirdGSM = new GSM("One X", "HTC", 850.0, "Georgi");
            
            //Outputing their info
            firstGSM.ToString();
            Console.WriteLine();
            secondGSM.ToString();
            Console.WriteLine();
            thirdGSM.ToString();

            Console.WriteLine();
            
            //Displaying info about iPhone 4S
            GSM.iPhone4S.ToString();

            //Create new instance
            GSM fourthGSM = new GSM("5230", "Nokia", 400.0, "Jivko");

            //Add calls
            fourthGSM.AddCall(DateTime.Now, "088088311", 55);
            fourthGSM.AddCall(DateTime.Now, "088088322", 68);
            fourthGSM.AddCall(DateTime.Now, "088088333", 33);

            //Print calls
            fourthGSM.PrintCalls();

            //Delete calls and Print
            Console.WriteLine("Delete call and print... ");
            fourthGSM.DeleteCalls(55);
            fourthGSM.PrintCalls();

            //Calculate total price
            fourthGSM.CalculateTotalPrice(0.37);


            //Clear calls and print
            fourthGSM.ClearCallHistory();
            fourthGSM.PrintCalls();

            
        }
    }
}
