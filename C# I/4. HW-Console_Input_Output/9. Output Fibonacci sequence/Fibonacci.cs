using System;
using System.Numerics;
class Fibonacci
{
    static void Main()
    {
        //Write a program to print the first 100 members of the sequence of Fibonacci
        //0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
        BigInteger firstMember = 0;
        BigInteger secondMember = 1;
        BigInteger nthMember;
        Console.WriteLine(firstMember);
        Console.WriteLine(secondMember);
        for (int i = 1; i < 100; i++)
        {
            nthMember = firstMember + secondMember;
            firstMember = secondMember;
            secondMember = nthMember;
            Console.WriteLine(nthMember);
        }
    }
}