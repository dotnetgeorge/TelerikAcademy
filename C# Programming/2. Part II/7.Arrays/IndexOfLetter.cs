/*
 * Write a program that creates an array containing all letters from the alphabet (A-Z). 
 * Read a word from the console and print the index of each of its letters in the array.
*/

using System;
using System.Collections.Generic;

class IndexOfLetter
{
    static void Main(string[] args)
    {
        Console.Write("Enter word: ");
        string word = Console.ReadLine();

        List<string> alphabet = new List<string>();
        for (int i = 65; i <= 90; i++)
        {
            alphabet.Add(Char.ConvertFromUtf32(i));
        }

        char[] symbols = word.ToCharArray();

        string result = null;

        for (int i = 0; i < symbols.Length; i++)
        {
            for (int j = 0; j < alphabet.Count; j++)
            {
                if (alphabet[j] == symbols[i].ToString().ToUpper())
                {
                    result += j.ToString() + " ";
                }
            }
        }
        Console.WriteLine(result);
    }
}