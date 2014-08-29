//Write an expression that checks if given integer is odd or even.

using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(number % 2 == 0 ? "Even" : "Odd");
        }
    }
}
