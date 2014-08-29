/*
 * Write a program that reverses the words in given sentence.
 * Example: "C# is not C++, not PHP and not Delphi!" 
 * -> "Delphi not and PHP, not C++ not is C#!".
 */
using System;

class ReverseSentence
{
    static void Main(string[] args)
    {
        Console.Write("Text:");
        string text = Console.ReadLine();

        char[] pattern = new char[] {' '};
        string[] elements = text.Split(pattern, StringSplitOptions.RemoveEmptyEntries);
        string reversed = "";
        for (int i = elements.Length - 1; i >= 0; i--)
        {
            reversed += elements[i] + " ";
        }
        Console.WriteLine(reversed);
    }
}