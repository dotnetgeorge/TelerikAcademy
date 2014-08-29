/*
 * Write a program that finds the maximal increasing sequence in an array. 
 * Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.

 */
using System;
using System.Collections.Generic;

class MaximalIncreasingSequence
{
    static void Main(string[] args)
    {
        Console.Write("Length:");
        int length = int.Parse(Console.ReadLine());

        int[] arr = new int[length];
        FillArr(arr);
    }

    static void FillArr(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Fill array[{0}]:", i + 1);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(MaxIncreasing(arr));
    }

    static string MaxIncreasing(int[] arr)
    {
        int length = 0;
        int max = 0;
        int current = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > arr[i - 1])
            {
                if (i - current + 1 > length)
                {
                    max = current;
                    length = i - current + 1;
                }
            }
            else
            {
                current = i;
            }
        }
        string result = "{";
        for (int i = max; i < length; i++)
        {
            result += arr[i] + ", ";
        }
        result += arr[length] + "}";
        return result;
    }
}