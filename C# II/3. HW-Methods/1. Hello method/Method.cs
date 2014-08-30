using System;

//Write a method that asks the user for his name and
//prints “Hello, <name>” (for example, “Hello,
//Peter!”). Write a program to test this method.


    class Method
    {
        //Create our method
        static void SayHello(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }

        static void Main()
        {
            //Input and variables
            Console.WriteLine("What's your name?");
            Console.Write("My name is: ");
            string name = Console.ReadLine();

            //Call our method
            SayHello(name);
        }
    }

