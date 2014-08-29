/*
 * Write a program that reads a string, reverses it and prints the result at the console.
 * Example: “sample” -> “elpmas”.
*/
using System;

class ReverseString
{
    static void Main(string[] args)
    {
        Console.Write("String:");
        string word = Console.ReadLine();
        Console.WriteLine("Reversed: ");
        for (int i = word.Length - 1; i >= 0; i--)
        {
            Console.Write(word[i]);
        }
        Console.WriteLine();
    }
}
