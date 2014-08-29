//Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).

using System;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double d, x, x1, x2;

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Every X is solution.");
                    }
                    else
                    {
                        Console.WriteLine("No solution.");
                    }
                }
                else
                {
                    x = -c / b;
                    Console.WriteLine("X = {0:0.00}", x);
                }
            }
            else
            {
                d = (b * b) - 4 * a * c;
                if (d > 0)
                {
                    x1 = (-b + Math.Sqrt(d)) / 2 * a;
                    x2 = (-b - Math.Sqrt(d)) / 2 * a;
                    Console.WriteLine("X1 = {0:0.00}\nX2 = {1:0.00}", x1, x2);
                }
                else
                {
                    if (d == 0)
                    {
                        x = -b / 2 * a;
                        Console.WriteLine("X = {0:0.00}", x);
                    }
                    else
                    {
                        Console.WriteLine("No real roots.");
                    }
                }
            }
        }
    }
}
