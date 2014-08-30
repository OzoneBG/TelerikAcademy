using System;
using System.Collections.Generic;
using System.Linq;

//You are given an array of strings. Write a method
//that sorts the array by the length of its elements
//(the number of characters composing them).


class SortStringArrayByLength
{
    static List<string> SortByLength(string[] str)
    {
        var sorted = from s in str
                     orderby ((string)s).Length ascending
                     select s;
        List<string> res = new List<string>(sorted);
        return res;
        //str.OrderByDescending(s => s.Length);
        //str.Reverse();
    }
    static void Main()
    {
        string[] input = { "a", "cc", "aaa", "bb", "dddd" };

        List<string> sorted = SortByLength(input);
        foreach (var item in sorted)
        {
            Console.WriteLine(item);
        }
    }
}

