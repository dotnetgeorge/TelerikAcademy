//Write a program that reads 3 integer numbers from the console and prints their sum.

using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum is " + (first + second + third));
        }
    }
}
