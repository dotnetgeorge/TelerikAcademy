/*
 * Write a method GetMax() with two parameters that returns the bigger of two integers.
 * Write a program that reads 3 integers from the console and prints 
 * the biggest of them using the method GetMax().
 */
using System;

class GetMax
{
    static void Main(string[] args)
    {
        Console.Write("First number: ");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Second number: ");
        int second = int.Parse(Console.ReadLine());
        int bigger =  GetMAX(first, second);
        Console.WriteLine("Max is: {0}!", bigger);
    }

    public static int GetMAX(int first, int second)
    {
        return first > second ? first : second;
    }
}