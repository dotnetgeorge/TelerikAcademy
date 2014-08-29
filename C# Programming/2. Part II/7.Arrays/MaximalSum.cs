/*
 * Write a program that finds the sequence of maximal sum in given array. Example:
 * {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> {2, -1, 6, 4}
 * Can you do it with only one loop (with single scan through the elements of the array)?
 */
using System;

class MaximalSum
{
    static void Main(string[] args)
    {
        Console.Write("Length:");
        int length = int.Parse(Console.ReadLine());

        int[] arr = new int[length];

        for (int i = 0; i < length; i++)
        {
            Console.Write("Fill array[{0}]:", i + 1);
            arr[i] = int.Parse(Console.ReadLine());
        }

        int start = 0, end = 0, max = 0, current = 0, index = 0;

        for (int i = 1; i < length - 1; i++)
        {
            if (current > 0)
            {
                current += arr[i];
            }
            else
            {
                current = arr[i];
                index = i;
            }

            if (current > max)
            {
                max = current;
                start = index;
                end = i;
            }
        }
        Console.Write("{");
        for (int i = start; i < end; i++)
        {
            Console.Write(arr[i] + ", ");
        }
        Console.WriteLine(arr[end] + "}");
    }
}