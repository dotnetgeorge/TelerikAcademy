//Write a program that finds the biggest of three integers using nested if statements.

using System;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            if (first > second)
            {
                if (first > third)
                {
                    Console.WriteLine(first);
                }
                else
                {
                    Console.WriteLine(third);
                }
            }
            else
            {
                if (second > third)
                {
                    Console.WriteLine(second);
                }
                else
                {
                    Console.WriteLine(third);
                }
            }
        }
    }
}
