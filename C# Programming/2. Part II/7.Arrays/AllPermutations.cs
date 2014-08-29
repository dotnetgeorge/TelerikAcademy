/*
 * *Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N]. 
 * Example:
 * n = 3 -> {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}
 */
using System;

class AllPermutations
{
    static void Main(string[] args)
    {
        Console.Write("Number:");
        int number = int.Parse(Console.ReadLine());
        int[] arr = new int[number];
        for (int i = 0; i < number; i++)
        {
            arr[i] = i + 1;
        }
        Permutations(arr, 0, arr.Length - 1);
    }

    static void Permutations(int[] arr, int index, int length)
    {
        if (index == length)
        {
            for (int i = 0; i <= length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        else
        {
            for (int i = index; i <= length; i++)
            {
                Swap(ref arr[i], ref arr[index]);
                Permutations(arr, index + 1, length);
                Swap(ref arr[i], ref arr[index]);
            }
        }
    }

    static void Swap(ref int first, ref int second)
    {
        int swap = first;
        first = second;
        second = swap;
    }
}