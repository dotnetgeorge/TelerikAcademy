/*
 * * Write a program that reads an array of integers and removes from it a minimal number of elements
 * in such way that the remaining array is sorted in increasing order. 
 * Print the remaining sorted array. 
 * Example:
 * {6, 1, 4, 3, 0, 3, 6, 4, 5} -> {1, 3, 3, 4, 5}
 */
using System;
using System.Collections.Generic;

class MinNumberElements
{
    static void Main(string[] args)
    {
        Console.Write("Length:");
        int length = int.Parse(Console.ReadLine());

        List<int> list = new List<int>();
        List<int> removed = new List<int>();

        for (int i = 0; i < length; i++)
        {
            Console.Write("[{0}] Add number:", i + 1);
            list.Add(int.Parse(Console.ReadLine()));
        }
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] != 0)
            {
                if (list[i] > list[i + 1])
                {
                    removed.Add(list[i + 1]);
                    list.Remove(list[i + 1]);
                }
                else
                {
                    removed.Add(list[i]);
                    list.Remove(list[i]);
                }
            }
        }
        removed.Sort();
        foreach (var item in removed)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}