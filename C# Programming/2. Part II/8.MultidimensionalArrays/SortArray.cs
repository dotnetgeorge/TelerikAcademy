/*
 * You are given an array of strings. Write a method that sorts the array 
 * by the length of its elements (the number of characters composing them).
 */
using System;
using System.Linq;

class SortArray
{
    static void Main(string[] args)
    {
        Console.Write("Length:");
        int length = int.Parse(Console.ReadLine());
        string[] matrix = new string[length];
        FillArr(matrix);
        ArraySort(matrix);
    }
    static void FillArr(string[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("[{0}] Add string:", i + 1);
            arr[i] = Console.ReadLine();
        }
    }
    static void ArraySort(string[] arr)
    {
        var sorted = from sort in arr
                     orderby sort.Length ascending
                     select sort;
        foreach (var item in sorted)
        {
            Console.WriteLine(item);
        }
    }
}