//Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. Example: v=5; p=1  false
using System;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int bit = int.Parse(Console.ReadLine());
            int mask = 1 << bit;
            int result = number & mask;
            result >>= bit;
            Console.WriteLine(result == 1 ? "True" : "False");
        }
    }
}
