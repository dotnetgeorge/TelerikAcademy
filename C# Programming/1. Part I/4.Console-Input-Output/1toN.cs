//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

using System;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());

            for (int i = 1; i <= end; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
