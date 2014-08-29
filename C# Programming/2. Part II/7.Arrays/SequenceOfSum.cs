/*
 Write a program that finds in given array of integers a sequence of given sum S (if present). 
 Example: {4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}	

*/
using System;

class SequenceOfSum
{
    static void Main(string[] args)
    {
        Console.Write("Length of array: ");
        int length = int.Parse(Console.ReadLine());

        Console.Write("S = ");
        int sum = int.Parse(Console.ReadLine());

        int[] arr = new int[length];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Fill array[{0}]:", i + 1);
            arr[i] = int.Parse(Console.ReadLine());
        }

        int current = 0, element = 0, start = 0, end = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            current += arr[i];
            if (current == sum)
            {
                start = element;
                end = i;
                break;
            }
            if (i == arr.Length - 1)
            {
                current = 0;
                element++;
                if (element == arr.Length)
                {
                    break;
                }
                i = element - 1;
            }
        }
        if (sum != current)
        {
            Console.WriteLine("Array doesn't have such sum!");
        }
        Console.Write("{");
        for (int i = start; i < end; i++)
        {
            Console.Write(arr[i]+ ", ");
        }
        Console.Write(arr[end] + "}");
        Console.WriteLine();
    }
}