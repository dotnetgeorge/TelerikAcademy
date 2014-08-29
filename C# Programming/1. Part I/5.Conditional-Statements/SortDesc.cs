//Sort 3 real values in descending order using nested if statements.

using System;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());

            if (first > second)
            {
                if (first > third)
                {
                    if (second > third)
                    {
                        Console.WriteLine("{0:0.00}\n{1:0.00}\n{2:0.00}", first, second, third);
                    }
                    else
                    {
                        Console.WriteLine("{0:0.00}\n{1:0.00}\n{2:0.00}", first, third, second);
                    }
                }
                else
                {
                    if (first > second)
                    {
                        Console.WriteLine("{0:0.00}\n{1:0.00}\n{2:0.00}", third, first, second);
                    }

                }
            }
            else
            {
                if (second > third)
                {
                    if (third > first)
                    {
                        Console.WriteLine("{0:0.00}\n{1:0.00}\n{2:0.00}", second, third, first);
                    }
                    else
                    {
                        Console.WriteLine("{0:0.00}\n{1:0.00}\n{2:0.00}", second, first, third);
                    }
                }
                else
                {
                    if (first > second)
                    {
                        Console.WriteLine("{0:0.00}\n{1:0.00}\n{2:0.00}", third, first, second);
                    }
                    else
                    {
                        Console.WriteLine("{0:0.00}\n{1:0.00}\n{2:0.00}", third, second, first);
                    }
                }
            }
        }
    }
}
