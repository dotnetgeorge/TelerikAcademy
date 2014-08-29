//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float h = float.Parse(Console.ReadLine());
            float result = ((a + b) / 2) * h;
            Console.WriteLine(result);
        }
    }
}
