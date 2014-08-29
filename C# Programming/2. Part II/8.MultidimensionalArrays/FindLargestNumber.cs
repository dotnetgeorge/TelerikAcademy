/*
 * Write a program, that reads from the console an array of N integers and an integer K,
 * sorts the array and using the method Array.BinSearch() finds 
 * the largest number in the array which is <= K. 
 */
using System;
using System.Collections.Generic;

class FindLargestNumber
{
    static void Main(string[] args)
    {
        Console.Write("Length:");
        int length = int.Parse(Console.ReadLine());
        Console.Write("Number:");
        int number = int.Parse(Console.ReadLine());

        int[] arr = new int[length];
        FillArray(arr);
        FindNumber(arr, number);
    }
    static void FillArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("[{0}] Add number:", i + 1);
            arr[i] = int.Parse(Console.ReadLine());
        }
    }
    static void FindNumber(int[] arr, int number)
    {
        Array.Sort(arr);
        int result = 0;
        if (number < arr[0])
        {
            Console.WriteLine("Number is too little.");
        }
        else
        {

            int index = Array.BinarySearch(arr, number);
            if (index >= 0)
            {
                result = arr[index];
            }
            else
            {
                result = arr[~index - 1];
            }
            Console.WriteLine(result);
        }
    }
}