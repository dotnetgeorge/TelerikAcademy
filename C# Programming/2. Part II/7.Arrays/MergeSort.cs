//* Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).

using System;
using System.Collections.Generic;

class MergeSort
{
    static void Main(string[] args)
    {
        Console.Write("Length of array: ");
        int length = int.Parse(Console.ReadLine());
        FillArray(length);
    }

    static void FillArray(int length)
    {
        int[] firstArr = new int[length];
        int[] secondArr = new int[length];
        for (int i = 0; i < length; i++)
        {
            Console.Write("Fill array[{0}]: ", i + 1);
            firstArr[i] = int.Parse(Console.ReadLine());
        }

        BottomUpSort(length, firstArr, secondArr);
    }

    static void BottomUpSort(int length, int[] firstArr, int[] secondArr)
    {
        for (int i = 1; i < length; i *= 2)
        {
            for (int j = 0; j < length; j += 2 * i)
            {
                BottomUpMerge(firstArr, j, Math.Min(j + i, length), Math.Min(j + (2 * i), length), secondArr); 
            }
            for (int k = 0; k < length; k++)
            {
                int swap = firstArr[k];
                firstArr[k] = secondArr[k];
                secondArr[k] = swap;
            }
        }

        PrintSort(firstArr);
    }
    static void BottomUpMerge(int[] firstArr, int iLeft, int iRight, int iEnd, int[] secondArr)
    {
        int i0 = iLeft;
        int i1 = iRight;
        for (int i = iLeft; i < iEnd; i++)
        {
            if (i0 < iRight && (i1 >= iEnd || firstArr[i0] <= firstArr[i1]))
            {
                secondArr[i] = firstArr[i0];
                i0 += 1;
            }
            else
            {
                secondArr[i] = firstArr[i1];
                i1 += 1;
            }
        }
    }
    static void PrintSort(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}