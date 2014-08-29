/*
 * Write a program that reads from the console a string of maximum 20 characters. 
 * If the length of the string is less than 20, 
 * the rest of the characters should be filled with '*'. 
 * Print the result string into the console.
*/
using System;

class FillArrayWithStar
{
    static void Main(string[] args)
    {
        int length = int.MinValue;
        do
        {
            Console.Write("Lenght:");
            length = int.Parse(Console.ReadLine());
        } while((length < 0) || (length > 20));

        string[] arr = new string[20];
        for (int i = 0; i < length; i++)
        {
            arr[i] = (i + 1).ToString();
        }
        if (length < 20)
        {
            for (int i = length; i <= 19; i++)
            {
                arr[i] = "*";
            }
        }
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }
}