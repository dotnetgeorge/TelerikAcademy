//Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).

using System;

class BiggerNeighbors
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
        CheckPosition(arr);
    }
    static void CheckPosition(int[] arr)
    {
        Console.Write("Position to check: ");
        int position = int.Parse(Console.ReadLine());

        if (position == arr[0])
        {
            if (arr[position] > arr[position + 1])
            {
                Console.WriteLine("Number {0} at position {1} is bigger than {2} at potion {3}", arr[position], position, arr[position + 1], position + 1);
            }
            else
            {
                Console.WriteLine("Number {0} at position {1} isn't bigger.", arr[position], position);
            }
        }
        else if (position == arr[arr.Length - 1])
        {
            if (arr[position] > arr[position - 1])
            {
                Console.WriteLine("Number {0} at position {1} is bigger than {2} at potion {3}", arr[position], position, arr[position - 1], position - 1);
            }
            else
            {
                Console.WriteLine("Number {0} at position {1} isn't bigger.", arr[position], position);
            }
        }
        else if((position > arr[0]) && (arr[arr.Length - 1] > position))
        {
            if ((arr[position] > arr[position - 1]) && (arr[position] > arr[position + 1]))
            {
                Console.WriteLine("Number {0} at position {1} is bigger than {2} at potion {3} and {4} at position {5}", arr[position], position, arr[position - 1], position - 1, arr[position + 1], position + 1);

            }
            else if (arr[position] > arr[position - 1])
            {
                Console.WriteLine("Number {0} at position {1} is bigger than {2} at potion {3}", arr[position], position, arr[position - 1], position - 1);
            }
            else if (arr[position] > arr[position + 1])
            {
                Console.WriteLine("Number {0} at position {1} is bigger than {2} at potion {3}", arr[position], position, arr[position + 1], position + 1);
            }
            else
            {
                Console.WriteLine("Number {0} at position {1} isn't bigger.", arr[position], position);
            }
        }
        else
        {
            Console.WriteLine("Array doen't have position {0}!!!", position);
        }
    }
}
