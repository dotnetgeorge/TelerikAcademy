/*
 Write a program that finds the most frequent number in an array. Example:
	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times)

*/
using System;

class MostFrequentNumber
{
    static void Main(string[] args)
    {
        int bestCount = int.MinValue;
        int bestNumber = 0;

        Console.Write("Length of array: ");
        int length = int.Parse(Console.ReadLine());

        int[] arr = new int[length];

        for (int i = 0; i < length; i++)
        {
            Console.Write("Fill array[{0}]: ", i + 1);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);
        //Sort(arr);
        int count = 1;
        int number = 0;
        for (int i = 0; i < length - 1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                count++;
                number = arr[i];
                if (bestCount < count)
                {
                    bestCount = count;
                    bestNumber = number;
                }
            }
            else
            {
                count = 1;
                number = 0;
            }
        }
        Console.WriteLine("{0} ({1} times)", bestNumber, bestCount);
    }

    //public static void Sort(int[] arr)
    //{
    //    //selection sort
    //    for (int i = 0; i < arr.Length - 1; i++)
    //    {
    //        int iMin = i;
    //        for (int j = i + 1; j < arr.Length; j++)
    //        {
    //            if (arr[j] < arr[iMin])
    //            {
    //                iMin = j;
    //            }
    //        }
    //        if (iMin != i)
    //        {
    //            int swap = arr[i];
    //            arr[i] = arr[iMin];
    //            arr[iMin] = swap;
    //        }
    //    }
    //}
}