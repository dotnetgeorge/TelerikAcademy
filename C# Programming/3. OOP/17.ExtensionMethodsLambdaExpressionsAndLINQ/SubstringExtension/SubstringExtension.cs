/*
 * Implement an extension method Substring(int index, int length)
 * for the class StringBuilder that returns new StringBuilder
 * and has the same functionality as Substring in the class String.
 */
namespace SubstringExtension
{
    using System;
    using System.Text;
    using SubstringExtension.Data;

    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("We love electronic music!");
            StringBuilder result = sb.Substring(8, sb.Length - 8);
            Console.WriteLine(result.ToString());
        }
    }
}
