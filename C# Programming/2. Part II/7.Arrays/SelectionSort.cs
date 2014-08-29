/*
 * Sorting an array means to arrange its elements in increasing order.
 * Write a program to sort an array. 
 * Use the "selection sort" algorithm: Find the smallest element, 
 * move it at the first position, find the smallest from the rest, 
 * move it at the second position, etc.
 */
using System;

class SelectionSort
{
    static void Main(string[] args)
    {
        Console.Write("Length of array: ");
        int length = int.Parse(Console.ReadLine());

        int[] arr = new int[length];

        //fill array
        for (int i = 0; i < length; i++)
        {
            Console.Write("Fill arr[{0}]: ", i + 1);
            arr[i] = int.Parse(Console.ReadLine());
        }

        //selection sort
        for (int i = 0; i < length - 1; i++)
        {
            int iMin = i;
            for (int j = i + 1; j < length; j++)
            {
                if (arr[j] < arr[iMin])
                {
                    iMin = j;
                }
            }
            if (iMin != i)
            {
                int swap = arr[i];
                arr[i] = arr[iMin];
                arr[iMin] = swap;
            }
        }

        //print array
        for (int i = 0; i < length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}