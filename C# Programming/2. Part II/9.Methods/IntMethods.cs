/*
 * Write methods to calculate minimum, maximum, average, sum 
 * and product of given set of integer numbers.
 * Use variable number of arguments.
 */
using System;

class IntMethods
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
            Console.Write("Fill array[{0}]: ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Minimum(arr);
        Maximum(arr);
        Average(arr);
        Sum(arr);
        Product(arr);
    }
    static void Minimum(int[] arr)
    {
        int minimum = int.MaxValue, temp = int.MaxValue;
        for (int i = 0; i < arr.Length; i++)
        {
            temp = Math.Min(temp, arr[i]);
            if (temp < minimum)
            {
                minimum = temp;
            }
        }
        Console.WriteLine("Minimum is: " + minimum);
    }
    static void Maximum(int[] arr)
    {
        int maximum = int.MinValue, temp = int.MinValue;
        for (int i = 0; i < arr.Length; i++)
        {
            temp = Math.Max(temp, arr[i]);
            if (maximum < temp)
            {
                maximum = temp;
            }
        }
        Console.WriteLine("Maximum is: " + maximum);
    }
    static void Average(int[] arr)
    {
        int sum = 0;
        foreach (var item in arr)
        {
            sum += item;
        }
        int average = ((int)sum / arr.Length);
        Console.WriteLine("Average is: " + average);
    }
    static void Sum(int[] arr)
    {
        int sum = 0;
        foreach (var item in arr)
        {
            sum += item;
        }
        Console.WriteLine("Sum is: " + sum);
    }
    static void Product(int[] arr)
    {
        int product = 1;
        foreach (var item in arr)
        {
            product *= item;
        }
        Console.WriteLine("Product is: " + product);
    }
}