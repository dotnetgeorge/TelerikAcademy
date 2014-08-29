/*
 * Write a method that asks the user for his name and prints “Hello, <name>” 
 * (for example, “Hello, Peter!”).
 * Write a program to test this method.
 */

using System;

class HelloName
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Hello(name);
    }

    public static void Hello(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }
}