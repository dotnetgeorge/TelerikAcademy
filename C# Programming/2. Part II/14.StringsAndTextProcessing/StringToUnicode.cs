/*
 * Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. 
 * Sample input: 
 * Hi!
 * Expected output:
 * \u0048\u0069\u0021
 */
using System;


class StringToUnicode
{
    static void Main(string[] args)
    {
        Console.Write("Text:");
        string text = Console.ReadLine();

        string unicode = String.Empty;
        for (int i = 0; i < text.Length; i++)
        {
            unicode += String.Format(@"\u{0:X4}", ((uint)text[i]));
        }

        Console.WriteLine(unicode);
    }
}