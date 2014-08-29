//Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true
using System;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine((number / 100) % 10 == 7 ? "True" : "False");
        }
    }
}
