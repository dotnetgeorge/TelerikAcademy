/*
 * We are given a string containing a list of forbidden words and a text 
 * containing some of these words. Write a program that replaces the forbidden 
 * words with asterisks. Example:
 * Microsoft announced its next generation PHP compiler today. 
 * It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
 * 
 * Words: "PHP, CLR, Microsoft"
 * The expected result:
 * ********* announced its next generation *** compiler today. 
 * It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.
 */
using System;

class CensureText
{
    static void Main(string[] args)
    {
        Console.Write("Text:");
        string text = Console.ReadLine();
        Console.Write("Words to censure:");
        string words = Console.ReadLine();

        char[] pattern = new char[]{' ', ',','!', '\n', '\t'};
        string[] censure = words.Split(pattern, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < censure.Length; i++)
        {
            if(text.Contains(censure[i]))
            {
                text = text.Replace(censure[i], new string('*', censure[i].Length));
            }
        }
        Console.WriteLine(text);
    }
}