using System;
using System.Text;

namespace ASCII_Table
{
    class AsciiTable
    {
        static void Main()
        {
            //Деклариране за изписване във UTF8
            Console.OutputEncoding = Encoding.UTF8;

            //Изписване на ASCII таблицата
            for (int i = 0; i <= 255; i++)
            {
                char symbol = (char)i;
                Console.WriteLine("ASCII symbol {0} and its number {1}", symbol, i);
            }
        }
    }
}
