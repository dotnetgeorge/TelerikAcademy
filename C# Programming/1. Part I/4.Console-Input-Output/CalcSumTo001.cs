//Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal result = 1m;
            for (decimal i = 2; 1 / i > 0.001m; i++)
            {
                result = i % 2 == 0 ? result + 1 / i : result - 1 / i;
            }
            Console.WriteLine(result);
        }
    }
}
