using System;

//Write a program that reads two numbers N and K
//and generates all the variations of K elements from
//the set [1..N]. Example:
//N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}


class GenerateVariations
{
    static void Variations(int[] arr, int index, int elements)
    {
        if (index == arr.Length)
        {
            PrintResult(arr);
        }
        else
        {
            for (int i = 1; i <= elements; i++)
            {
                arr[index] = i;
                Variations(arr, index + 1, elements);
            }
        }
    }

    static void PrintResult(int[] arr)
    {
        foreach (int element in arr)
        {
            Console.Write("{0} ", element);
        }
        Console.WriteLine();
    }


    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[k];
        Variations(arr, 0, n);
    }
}