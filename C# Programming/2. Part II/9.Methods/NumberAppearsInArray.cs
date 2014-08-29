/*
 * Write a method that counts how many times given number appears in given array. 
 * Write a test program to check if the method is working correctly.
 */
using System;

class NumberAppearsInArray
{
    static void Main(string[] args)
    {
        Console.Write("Length of array: ");
        int length = int.Parse(Console.ReadLine());
        FillArray(length);
    }

    static void FillArray(int length)
    {
        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            Console.Write("Fill array[{0}]: ", i + 1);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Number to find: ");
        int number = int.Parse(Console.ReadLine());
        NumberAppears(arr, number);
    }

    public static void NumberAppears(int[] arr, int number)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == number)
            {
                count++;
            }
        }
        Console.WriteLine("{0} appears in array {1} times.", number, count);
    }
}
