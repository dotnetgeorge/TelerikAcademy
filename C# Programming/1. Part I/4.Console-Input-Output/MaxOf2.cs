//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

using System;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());

            Console.WriteLine(first > second ? first : second);
        }
    }
}
