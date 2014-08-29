/*
 * Write a program that reads a string from the console and prints 
 * all different letters in the string along with information 
 * how many times each letter is found. 
 */
using System;
using System.Collections.Generic;

class PrintAllLetters
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("String:");
            string word = Console.ReadLine();

            char[] elements = word.ToCharArray();
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            foreach (char item in elements)
            {
                if (dictionary.ContainsKey(item.ToString()))
                {
                    dictionary[item.ToString()] += 1;
                }
                else
                {
                    dictionary.Add(item.ToString(), 1);
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
        catch (IndexOutOfRangeException ioore)
        {
            Console.Error.WriteLine(ioore.Message);
        }
        catch (ArgumentException ae)
        {
            Console.Error.WriteLine(ae.Message);
        }
    }
}