using System;


namespace Compare_Float_Points
{
    class CompareFloatPoints
    {
        static void Main()
        {
            //Деклариране на променливи
            double x, y;

            //Присвояване на данни към променливите
            Console.WriteLine("Input float for x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Input float for y");
            y = double.Parse(Console.ReadLine());

            //Проверка
            bool areEqual = Math.Abs(x - y) < 0.000001;


            //Изписване
            Console.WriteLine("({0} ; {1} ) --> {2}", x, y, areEqual);
        }
    }
}
