//Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).

using System;

class BinarySearch
{
    static void Main(string[] args)
    {
        Console.Write("Length of array: ");
        int length = int.Parse(Console.ReadLine());

        int[] arr = new int[length];

        Console.Write("Key = ");
        int key = int.Parse(Console.ReadLine());

        for (int i = 0; i < length; i++)
        {
            Console.Write("Fill Array[{0}]: ", i + 1);
            arr[i] = int.Parse(Console.ReadLine());
        }
        int result = BinarySearching(arr, key);
        Console.WriteLine(result);
    }

    public static int BinarySearching(int[] arr, int key)
    {
        int iMin = arr[0];
        int iMax = arr[arr.Length - 1];
        int iMid = arr.Length / 2;
        while (iMax >= iMin)
        {
            if (arr[iMid] == key)
            {
                return iMid;
            }
            else if (arr[iMid] < key)
            {
                iMin = iMid + 1;
            }
            else
            {
                iMax = iMid - 1;
            }
        }
        return int.MinValue;
    }
}