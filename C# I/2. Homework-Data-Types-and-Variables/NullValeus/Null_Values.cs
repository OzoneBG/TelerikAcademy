using System;

namespace Null_Values
{
    class NullValues
    {
        static void Main()
        {
            //Деклариране на променливи
            int? nullValueOne = null;
            double? nullValueTwo = null;

            //Изписването им
            Console.WriteLine("First null variable: {0} and Second null variable: {1}", nullValueOne, nullValueTwo);
            Console.WriteLine(nullValueTwo);

            //Промяна на едната променлива
            nullValueOne = 5;


            //Изписваме я
            Console.WriteLine(nullValueOne);
        }
    }
}
