using System;
using System.Text;

namespace Copyright_Triangle
{
    class Program
    {
        static void Main()
        {
            //Деклариране на променливи
            char copyRight = '©';

            //Декларираме да изписва във UTF8
            Console.OutputEncoding = Encoding.UTF8;

            //Изписване на триъгълника
            Console.WriteLine(@"
             {0}
           {0} {0}
          {0} {0} {0}
         {0} {0} {0}", copyRight);
        }
    }
}
