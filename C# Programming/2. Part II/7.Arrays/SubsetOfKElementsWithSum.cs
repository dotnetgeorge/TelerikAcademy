/*
 * *Write a program that reads three integer numbers N, K and S 
 * and an array of N elements from the console. 
 * Find in the array a subset of K elements that have sum S 
 * or indicate about its absence.
 */
using System;

class SubsetOfKElementsWithSum
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Length of array:");
            int lengthArray = int.Parse(Console.ReadLine());
            Console.Write("Length of subset:");
            int lengthOfSubset = int.Parse(Console.ReadLine());
            Console.Write("Sum:");
            int sum = int.Parse(Console.ReadLine());

            int current = 0, start = 0, end = 0, index = 0;
            int[] arr = new int[lengthArray];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("[{0}] Add number:", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                index = i;
                int loop = lengthOfSubset;
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
                    }
                    index++;
                    loop--;
                }
                if (current == sum)
                {
                    start = i;
                    end = index;
                }
                current = 0;
            }
            for (int i = start; i < end; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        catch (FormatException fe)
        {
            Console.Error.WriteLine(fe.Message);
        }
        catch (IndexOutOfRangeException ioore)
        {
            Console.Error.WriteLine(ioore.Message);
        }
    }
}