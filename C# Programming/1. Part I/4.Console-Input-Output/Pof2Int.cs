//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

using System;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int begin = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = begin; i <= end; i++)
            {
                Console.Write(i % 5 == 0 ? i + "\n"  : null);
            }
        }
    }
}
