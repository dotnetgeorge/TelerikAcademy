/*
 * Write a program that extracts from a given text all sentences containing given word.
 * Example: The word is "in". The text is:
 * We are living in a yellow submarine. We don't have anything else. 
 * Inside the submarine is very tight. So we are drinking all the day.
 * We will move out of it in 5 days.
 * 
 * The expected result is:
 * We are living in a yellow submarine.
 * We will move out of it in 5 days.
 * 
 * Consider that the sentences are separated by "." and the words – by non-letter symbols.
 */
using System;
using System.Collections.Generic;

class ExtractSentences
{
    static void Main(string[] args)
    {
        Console.Write("Text:");
        string text = Console.ReadLine();
        Console.Write("Search word:");
        string word = Console.ReadLine();

        List<string> result = new List<string>();
        char[] pattern = new char[]{'.', '!', '?'};
        string[] elements = text.Split(pattern, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < elements.Length; i++)
        {
            string find = " " + word + " ";
            if (elements[i].Contains(find))
            {
                Console.WriteLine(elements[i]);
            }
        }
    }
}