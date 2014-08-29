/*
 * *We are given an array of integers and a number S.
 * Write a program to find if there exists a subset of the elements of the array that has a sum S. 
 * Example:
 * arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14 -> yes (1+2+5+6)
 */
using System;
using System.Text;
using System.Collections.Generic;

class ExistsSubset
{
    static void Main(string[] args)
    {
        Console.Write("Length:");
        int length = int.Parse(Console.ReadLine());
        Console.Write("Sum:");
        int sum = int.Parse(Console.ReadLine());

        List<int> list = new List<int>();

        for (int i = 0; i < length; i++)
        {
            Console.Write("[{0}]Add number:", i + 1);
            list.Add(int.Parse(Console.ReadLine()));
        }
        FindExactSubset(list, sum);
    }

    static void FindExactSubset(List<int> arr, int sum)
    {
        int count = (int)Math.Pow(2, arr.Count);
        int currentSum = 0;
        bool foundSubset = false;
        StringBuilder str = new StringBuilder();

        for (int i = 1; i <= count; i++)
        {
            for (int j = 0; j < arr.Count; j++)
            {
                if ((i >> j & 1) == 1)
                {
                    if (currentSum == 0)
                    {
                        str.Append(arr[j]);
                    }
                    else
                    {
                        str.Append("+").Append(arr[j]);
                    }
                    currentSum += arr[j];
                }
            }
            if (currentSum == sum)
            {
                Console.WriteLine("Yes({0})", str);
                foundSubset = true;
                break;
            }
            else
            {
                currentSum = 0;
                str.Clear();
            }
        }
        if (foundSubset == false)
        {
            Console.WriteLine("Subset with this sum does not exist");
        }
    }
}