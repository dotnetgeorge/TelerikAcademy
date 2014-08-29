//Write a program that prints an isosceles triangle of 9 copyright symbols ©. Use Windows Character Map to find the Unicode code of the © symbol. Note: the © symbol may be displayed incorrectly.

using System;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = '©';
            Console.WriteLine("     {0}        ", ch);
            Console.WriteLine("    {0}{0}       ", ch);
            Console.WriteLine("   {0}{0}{0}{0}   ", ch);
        }
    }
}