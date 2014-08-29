/*
 * A dictionary is stored as a sequence of text lines containing words and their explanations. 
 * Write a program that enters a word and translates it by using the dictionary. 
 * Sample dictionary:
 * .NET – platform for applications from Microsoft
 * CLR – managed execution environment for .NET
 * namespace – hierarchical organization of classes
 */
using System;
using System.Text;
using System.Collections.Generic;

class Dictionary
{
    static void Main(string[] args)
    {
        List<string> dictionary = new List<string>();
        dictionary.Add(".NET – platform for applications from Microsoft");
        dictionary.Add("CLR – managed execution environment for .NET");
        dictionary.Add("namespace – hierarchical organization of classes");

        Console.Write("Word:");
        string word = Console.ReadLine();

        for (int i = 0; i < dictionary.Count; i++)
        {
            if (dictionary[i].Contains(word))
            {
                Console.WriteLine(dictionary[i]);
                break;
            }
        }
    }
}