//Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.

using System;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());

            if (first > 0)
            {
                Console.WriteLine("+{0:0.00}", first);
            }
            else 
            {
                Console.WriteLine("{0:0.00}", first);
            }
            if (second > 0)
            {
                Console.WriteLine("+{0:0.00}", second);
            }
            else
            {
                Console.WriteLine("{0:0.00}", second);
            }
            if (third > 0)
            {
                Console.WriteLine("+{0:0.00}", third);
            }
            else
            {
                Console.WriteLine("{0:0.00}", third);
            }
        }
    }
}
