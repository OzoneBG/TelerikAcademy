using System;

namespace Person
{
    class IO
    {
        static void Main()
        {
            Person person1 = new Person("Nasko", "18");
            Person person2 = new Person("Georgi");

            Console.WriteLine("\n\n <== First Person with specified age ==>");
            Console.WriteLine(person1.ToString());
            Console.WriteLine("\n\n <== Second Person without specified age ==>");
            Console.WriteLine(person2.ToString());
            Console.WriteLine();
        }
    }
}
