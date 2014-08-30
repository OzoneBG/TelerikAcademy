using System;

//Write a program that reads two numbers N and K
//and generates all the combinations of K distinct
//elements from the set [1..N]. Example:
//N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}


class GenerateCombinations
{
    static int elements = 5;
    static void Combinations(int[] array, int index, int currentNumber)
    {
        if (index == array.Length)
        {
            PrintResult(array);
        }
        else
        {
            for (int i = currentNumber; i <= elements; i++)
            {
                array[index] = i;
                Combinations(array, index + 1, i + 1);
            }
        }

    }

    static void PrintResult(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }


    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[k];
        Combinations(arr, 0, 1);
    }
}