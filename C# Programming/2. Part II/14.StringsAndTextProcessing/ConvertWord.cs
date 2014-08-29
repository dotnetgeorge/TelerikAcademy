/*
 * Write a program that reads a string from the console and replaces 
 * all series of consecutive identical letters with a single one. 
 * Example: "aaaaabbbbbcdddeeeedssaa" -> "abcdedsa".
 */
using System;

class ConvertWord
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Word:");
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length - 1; i++)
            {
                if (word[i] == word[i + 1])
                {
                    word = word.Remove(i, 1);
                    i--;
                }
            }
            Console.WriteLine(word);
        }
        catch (FormatException fe)
        {
            Console.Error.WriteLine(fe.Message);
        }
        catch (ArgumentException ae)
        {
            Console.Error.WriteLine(ae.Message);
        }
        catch (IndexOutOfRangeException ioore)
        {
            Console.Error.WriteLine(ioore.Message);
        }
    }
}