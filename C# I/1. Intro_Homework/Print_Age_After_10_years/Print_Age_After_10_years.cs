using System;


namespace Print_Age_After_10_years
{
    class Print_Age_After_10_years
    {
        static void Main()
        {
            int age;
            Console.WriteLine("Please input your age to see how old are you going to be in 10 years.");
            age = int.Parse(Console.ReadLine());
            age = age + 10;
            Console.WriteLine("Your age after 10 years will be: " + age );
        }
    }
}
