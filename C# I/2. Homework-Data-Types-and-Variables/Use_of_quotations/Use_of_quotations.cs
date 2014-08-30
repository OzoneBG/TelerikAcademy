using System;


namespace Use_of_quotations
{
    class UseOfQuotations
    {
        static void Main()
        {   
            //Деклариране на променливи
            string first = "The \"use\" of quotations causes difficulties.",
                   second = @"The ""use"" of quotations causes difficulties.";


            //Изписване
            Console.WriteLine(first);
            Console.WriteLine();
            Console.WriteLine(second);
        }
    }
}
