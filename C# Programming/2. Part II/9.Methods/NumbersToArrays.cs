/*
 * Write a method that adds two positive integer numbers represented as arrays of digits 
 * (each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
 * Each of the numbers that will be added could have up to 10 000 digits.
 */
using System;
using System.Collections.Generic;

class NumbersToArrays
{
    static void Main(string[] args)
    {
        Console.Write("First number:");
        string firstNumber = Console.ReadLine();
        Console.Write("Second number:");
        string secondNumber = Console.ReadLine();
        ToArrays(firstNumber, secondNumber);
    }

    static void ToArrays(string firstNumber, string secondNumber)
    {
        int[] firstArr = new int[firstNumber.Length];
        int[] secondArr = new int[secondNumber.Length];

        firstArr[0] = Convert.ToInt32(firstNumber[firstNumber.Length - 1].ToString(), 10);
        secondArr[0] = Convert.ToInt32(secondNumber[secondNumber.Length - 1].ToString(), 10);

        for (int i = 1; i < firstArr.Length; i++)
        {
            firstArr[i] = Convert.ToInt32(firstNumber[i - 1].ToString(), 10);
        }
        for (int i = 1; i < secondArr.Length; i++)
        {
            secondArr[i] = Convert.ToInt32(secondNumber[i - 1].ToString(), 10);
        }
        PrintArrays(firstArr, secondArr);
    }

    static void PrintArrays(int[] first, int[] second)
    {
        Console.WriteLine("First:");
        foreach (var item in first)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\nSecond:");
        foreach (var item in second)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}