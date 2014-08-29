//Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double P = 2 * Math.PI * radius;
            double S = Math.PI * (radius * radius);

            Console.WriteLine("P={0}\nS={1}", P, S);
        }
    }
}
