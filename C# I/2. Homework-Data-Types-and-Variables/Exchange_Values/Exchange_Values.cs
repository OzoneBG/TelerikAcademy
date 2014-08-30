using System;


namespace Exchange_Values
{
    class ExchangeValues
    {
        static void Main()
        {
            //Деклариране на променливи
            int x = 5, y = 10, z;

            //Изписване на променливите
            Console.WriteLine("X = {0}", x);
            Console.WriteLine("Y = {0}", y);

            //Обмяна
            z = x;
            x = y;
            y = z;

            //Изписване
            Console.WriteLine("X after exchange: {0}", x);
            Console.WriteLine("Y after exchange: {0}", y);
        }
    }
}
