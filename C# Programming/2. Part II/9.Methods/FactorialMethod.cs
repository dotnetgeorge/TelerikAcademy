/*
 * Write a program to calculate n! for each n in the range [1..100]. 
 * Hint: Implement first a method that multiplies a number 
 * represented as array of digits by given integer number. 
 */
using System;
using System.Numerics;

class FactorialMethod
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 100; i++)
        {
            Factorial(i);
        }
    }
    static void Factorial(int number)
    {
        int num = number;
        BigInteger factorial = 1;
        do
        {
            factorial *= number;
            number--;
        } while (number > 0);
        Console.WriteLine("{0}!={1}", num, factorial);
    }
}