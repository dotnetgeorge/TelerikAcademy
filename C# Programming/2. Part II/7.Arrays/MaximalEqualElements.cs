/*
 Write a program that finds the maximal sequence of equal elements in an array.
		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}.

 */
using System;

class MaximalEqualElements
{
    static void Main(string[] args)
    {
        Console.Write("Length of array: ");
        int length = int.Parse(Console.ReadLine());

        int[] arr = new int[length];
        int bestCount = 0, bestNumber = 0;
        int number = 0, count = 0;

        for (int i = 0; i < length; i++)
        {
            Console.Write("Fill array[{0}]: ", i + 1);
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < length - 1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                number = arr[i];
                count++;
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
        Console.Write("{");
        for (int i = 0; i < bestCount - 1; i++)
        {
            Console.Write(bestNumber + ", ");
        }
        Console.WriteLine(bestNumber +"}");
        Console.WriteLine();
    }
}