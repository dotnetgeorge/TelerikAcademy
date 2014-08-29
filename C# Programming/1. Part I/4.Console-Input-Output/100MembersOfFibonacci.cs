//Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;
namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            long prev = 0, now = 1, temp = 0;
            sbyte count = 1;

            while (count <= 100)
            {
                temp = prev;
                prev = now;
                now = temp + prev;
                Console.WriteLine(now);
                count++;
            }
            Console.ReadKey();
        }
    }
}
