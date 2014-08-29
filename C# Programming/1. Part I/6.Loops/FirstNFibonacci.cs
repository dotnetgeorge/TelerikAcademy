//Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
using System;
using System.Numerics;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger sum = 0;
            while (number >= 1)
            {
                sum += (BigInteger)number * ((BigInteger)number - 1);
                number--;
            }
            Console.WriteLine(sum);
        }
    }
}
