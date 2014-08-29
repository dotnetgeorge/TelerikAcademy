/*
 * Write a program that encodes and decodes a string using given encryption key (cipher). 
 * The key consists of a sequence of characters. 
 * The encoding/decoding is done by performing XOR (exclusive or) 
 * operation over the first letter of the string with the first of the key,
 * the second – with the second, etc. When the last key character is reached, the next is the first.
 */
using System;
using System.Text;
using System.Collections.Generic;

class XOR
{
    static void Main(string[] args)
    {
        Console.Write("Text:");
        string text = Console.ReadLine();
        Console.Write("Key:");
        string key = Console.ReadLine();

        int choice = 0;
        do
        {
            Console.WriteLine("Choose option:");
            Console.WriteLine("1. Encrypt");
            Console.WriteLine("2. Decrypt");
            Console.Write("Your choice:");
            choice = int.Parse(Console.ReadLine());
        } while (choice < 1 || choice > 2);

        if (choice == 1)
        {
            Console.WriteLine(Encrypt(text, key));
        }
        else
        {
            Console.WriteLine(Decrypt(text, key));
        }
    }

    static string Encrypt(string text, string key)
    {
        string result = String.Empty;
        for (int i = 0; i < text.Length; i++)
        {
            result += String.Format("{0:00}", text[i] ^ key[i % key.Length]);
        }
        return result;
    }

    static string Decrypt(string text, string key)
    {
        string result = String.Empty;
        for (int i = 0; i < text.Length; i += 2)
        {
            byte code = Convert.ToByte(text.Substring(i, 2));
            result += (char)(code ^ key[(i / 2) % key.Length]);
        }
        return result;
    }
}