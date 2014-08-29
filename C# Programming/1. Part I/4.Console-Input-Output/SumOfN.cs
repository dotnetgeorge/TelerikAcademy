//Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

using System;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= start; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}
