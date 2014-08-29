/*
 * Write a program that reads a list of words,
 * separated by spaces and prints the list in an alphabetical order.
 */
using System;
using System.Collections.Generic;

class SortWordsList
{
    static void Main(string[] args)
    {
        Console.Write("Words:");
        string words = Console.ReadLine();
        char[] pattern = new char[] { ' ', ',', '!', '?', '\n', '\t' };
        string[] elements = words.Split(pattern, StringSplitOptions.RemoveEmptyEntries);
        List<string> list = new List<string>();
        for (int i = 0; i < elements.Length; i++)
        {
            list.Add(elements[i]);
        }
        list.Sort();
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}