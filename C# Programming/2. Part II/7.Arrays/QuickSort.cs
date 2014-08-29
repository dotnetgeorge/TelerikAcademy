//Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).

using System;
using System.Collections.Generic;

class QuickSort
{
    static void Main(string[] args)
    {
        Console.Write("Length of array: ");
        int length = int.Parse(Console.ReadLine());

        string[] array = new string[length];

        for (int i = 0; i < length; i++)
        {
            Console.Write("Fill array[{0}]: ", i + 1);
            array[i] = Console.ReadLine();
        }
        QuickSortTest(array, 0, array.Length - 1);
        PrintArray(array);

    }

    static void QuickSortTest(IComparable[] elements, int left, int right)
    {
        int i = left, j = right;
        IComparable pivot = elements[(left + right) / 2];

        while (i <= j)
        {
            while (elements[i].CompareTo(pivot) < 0)
            {
                i++;
            }

            while (elements[j].CompareTo(pivot) > 0)
            {
                j--;
            }

            if (i <= j)
            {
                IComparable swap = elements[i];
                elements[i] = elements[j];
                elements[j] = swap;

                i++;
                j--;
            }
        }

        if (left < j)
        {
            QuickSortTest(elements, left, j);
        }
        if (i < right)
        {
            QuickSortTest(elements, i, right);
        }
    }

    static void PrintArray(IComparable[] elements)
    {
        foreach (var item in elements)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}