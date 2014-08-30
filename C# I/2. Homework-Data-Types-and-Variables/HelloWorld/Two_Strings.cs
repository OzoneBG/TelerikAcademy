using System;


namespace Two_Strings
{
    class TwoStrings
    {
        static void Main()
        {
            //Деклариране и присвояване на стрингове
            string hello = "Hello", world = "World";
            //Свързване на 2 променливи в обект obj
            object obj = hello + " " + world;

            //Превръщане на обекта в стринг
            string myString = (string)obj;

            //Изписване
            Console.WriteLine(myString);
        }
    }
}
