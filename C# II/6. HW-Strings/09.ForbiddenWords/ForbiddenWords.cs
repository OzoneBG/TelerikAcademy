﻿// We are given a string containing a list of forbidden words and a
// text containing some of these words. Write a program that replaces the
// forbidden words with asterisks. Example:
// Microsoft announced its next generation PHP compiler today. It is
// based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
// Words: "PHP, CLR, Microsoft"
// 		The expected result:
// ********* announced its next generation *** compiler today. It is based on
// .NET Framework 4.0 and is implemented as a dynamic language in ***.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class ForbiddenWords
{
    static void Words()
    {
        string text = @"Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string forbiddenWord = "PHP, CLR, Microsoft";
        string[] forbidden = forbiddenWord.Split(',');
        StringBuilder result = new StringBuilder(text);
        for (int i = 0; i < forbidden.Length; i++)
        {
            forbidden[i] = forbidden[i].Trim();
            result.Replace(forbidden[i], new string('*', forbidden[i].Length));
        }
        Console.WriteLine(result);
        
    }
    static void Main()
    {
         Words();
    }
}

