/*
 * Write a program that reads a string from the console and lists
 * all different words in the string along with information 
 * how many times each word is found.
 */
using System;
using System.Collections.Generic;

class ListWords
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("String:");
            string sentence = Console.ReadLine();

            char[] pattern = new char[] { ' ', ',', '!', '.', '?', '\n' };
            string[] elements = sentence.Split(pattern, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            foreach (var item in elements)
            {
                if (dictionary.ContainsKey(item))
                {
                    dictionary[item] += 1;
                }
                else
                {
                    dictionary.Add(item, 1);
                }
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine("{0} - {1}", item.Key, item.Value);
            }
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