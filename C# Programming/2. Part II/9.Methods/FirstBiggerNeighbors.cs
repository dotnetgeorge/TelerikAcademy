/*
 * Write a method that returns the index of the first element in array
 * that is bigger than its neighbors, or -1, if there’s no such element.
 * Use the method from the previous exercise.
*/
using System;

class FirstBiggerNeighbors
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
        FindPosition(arr);
    }

    static void FindPosition(int[] arr)
    {
        int result = -1;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if ((i == 0) || (i == arr.Length - 1))
            {
                continue;
            }
            else
            {
                if ((arr[i - 1] < arr[i]) && (arr[i] > arr[i + 1]))
                {
                    result = i;
                    break;
                }
            }
        }
        Console.WriteLine(result == -1 ? "-1\tDoen\'t have such element." : "First element is on position: "+ result);
    }
}