/*
 * *Modify your last program and try to make it work for any number type,
 * not just integer (e.g. decimal, float, byte, etc.). 
 * Use generic method (read in Internet about generic methods in C#).
 */
using System;
using System.Collections.Generic;

class NumberTypeMethods
{
    static void Main(string[] args)
    {
        int[] arr = new int[]{ 1, 5, 8, 4, 6, 10};
        Console.WriteLine("Minimum is: " + Minimum(arr));
        Console.WriteLine("Maximum is: " + Maximum(arr));
        Console.WriteLine("Average is: " + Average(arr));
        Console.WriteLine("Sum is: " + Sum(arr));
        Console.WriteLine("Product is: " + Product(arr));
    }
    static T Minimum<T>(T[] arr)
    {
        Array.Sort(arr);
        return arr[0];
    }
    static T Maximum<T>(T[] arr)
    {
        Array.Sort(arr);
        Array.Reverse(arr);
        return arr[0];
        
    }
    static double Average<T>(T[] arr)
    {
        return Convert.ToDouble(Sum(arr)) / arr.Length;
    }
    static T Sum<T>(T[] arr)
    {
        dynamic sum = 0;
        foreach (T item in arr)
        {
            sum += item;
        }
        return sum;
    }
    static T Product<T>(T[] arr)
    {
        dynamic product = 1;
        foreach (T item in arr)
        {
            product *= item;
        }
        return product;
    }
}