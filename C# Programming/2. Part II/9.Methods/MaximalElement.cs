/*
 * Write a method that return the maximal element in a portion of array of integers 
 * starting at given index. Using it write another method that sorts
 * an array in ascending / descending order.
 */
using System;
using System.Collections.Generic;

class MaximalElement
{
    static void Main(string[] args)
    {
        Console.Write("Length:");
        int length = int.Parse(Console.ReadLine());
        Console.Write("Start at index:");
        int index = int.Parse(Console.ReadLine());
        int[] arr = new int[length];
        FillArray(arr);
        FindMaxEl(arr, index);
        Sort(arr);
    }
    static void FillArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Fill array[{0}]:", i + 1);
            arr[i] = int.Parse(Console.ReadLine());
        }
    }
    static void FindMaxEl(int[] arr, int index)
    {
        int max = int.MinValue;
        for (int i = index; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        Console.WriteLine("Max element is:" + max);
    }
    static void Sort(int[] arr)
    {
        int choose = 0;
        do
        {
            Console.WriteLine("1. Ascending");
            Console.WriteLine("2. Descending");
            Console.Write("Your choose:");
            choose = int.Parse(Console.ReadLine());
        } while (choose < 1 || choose > 2);
        if (choose == 1)
        {
            Array.Sort(arr);
        }
        else
        {
            Array.Sort(arr);
            Array.Reverse(arr);
        }
        Console.WriteLine("Sorted array:");
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}