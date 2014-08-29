/*
 * Write a program that reads two integer numbers N and K and an array of N elements from the console. 
 * Find in the array those K elements that have maximal sum.
 */
using System;

class MaxSumOfK
{
    static void Main(string[] args)
    {
        Console.Write("Length:");
        int length = int.Parse(Console.ReadLine());
        Console.Write("Number of elements:");
        int numberOfElements = int.Parse(Console.ReadLine());

        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            Console.Write("[{0}] Add number:", i + 1);
            arr[i] = int.Parse(Console.ReadLine());
        }

        int current = 0, max = 0, start = 0, end = 0, index = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            int loop = numberOfElements;
            index = i;
            if (index == arr.Length - 1)
            {
                break;
            }
            while (loop > 0)
            {
                if (index == arr.Length - 1)
                {
                    break;
                }
                else
                {
                    current += arr[index];
                    index++;
                }
                loop--;
            }
            if (current > max)
            {
                max = current;
                start = i;
                end = index;
            }
            current = 0;
        }
        Console.WriteLine("Max sum is: {0}", max);
        for (int i = start; i < end; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}