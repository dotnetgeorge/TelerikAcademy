/*
 * Write a program that finds how many times a substring is contained
 * in a given text (perform case insensitive search).
 * Example: The target substring is "in". The text is as follows:
 * 
 * We are living in an yellow submarine. We don't have anything else. 
 * Inside the submarine is very tight. So we are drinking all the day. 
 * We will move out of it in 5 days.
 * 
 * The result is: 9.
 */
using System;
using System.Collections.Generic;

class CountSubstring
{
    static void Main(string[] args)
    {
        Console.Write("Text: ");
        string text = @Console.ReadLine();

        Console.Write("Find substring: ");
        string substring = Console.ReadLine();

        int count = 1;

        if (text.Contains(substring))
        {
            int index = text.IndexOf(substring);
            while (index != -1)
            {
                index = text.IndexOf(substring, index + 1);
                count++;
            }
            Console.WriteLine("{0} founded {1} times in text.", substring, count);
        }
        else
        {
            Console.WriteLine("Text doesn't have this substring.");
        }

    }
}