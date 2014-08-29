/*
 * You are given a text. Write a program that changes the text in all regions 
 * surrounded by the tags <upcase> and </upcase> to uppercase. 
 * The tags cannot be nested. Example:
 * We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
 * The expected result:
 * We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
 */
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class UpCaseWord
{
    static void Main(string[] args)
    {
        Console.Write("Enter text:");
        string text = Console.ReadLine();

        var result = Regex.Replace(text, "<upcase>(.*?)</upcase>", m => m.Groups[1].Value.ToUpper());
        Console.WriteLine(result);
    }
}