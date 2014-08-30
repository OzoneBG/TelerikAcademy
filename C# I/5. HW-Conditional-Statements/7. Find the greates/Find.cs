using System;


namespace _7.Find_the_greatest
{
    class Find
    {
        static void Main()
        {
            //Declare variables
            int first, second, third, fourth, fifth;

            //Assign values for them
            Console.Write("First int = ");
            first = int.Parse(Console.ReadLine());

            Console.Write("Second int = ");
            second = int.Parse(Console.ReadLine());

            Console.Write("Third int = ");
            third = int.Parse(Console.ReadLine());

            Console.Write("Fourth int = ");
            fourth = int.Parse(Console.ReadLine());

            Console.Write("Fifth int = ");
            fifth = int.Parse(Console.ReadLine());

            if (first > second && first > third && first > fourth && first > fifth)
            {
                Console.WriteLine("The biggest number is: {0}", first);
            }
            else if (second > first && second > third && second > fourth && second > fifth) 
            {
                Console.WriteLine("The biggest number is: {0}", second);
            }
            else if (third > first && third > second && third > fourth && third > fifth)
            {
                Console.WriteLine("The biggest number is: {0}", third);
            }
            else if (fourth > first && fourth > second && fourth > third && fourth > fifth)
            {
                Console.WriteLine("The biggest number is: {0}", fourth);
            }
            else
            {
                Console.WriteLine("The biggest number is: {0}", fifth);
            }
        }
    }
}
