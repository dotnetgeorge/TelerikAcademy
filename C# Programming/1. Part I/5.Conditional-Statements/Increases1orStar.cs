//Write a program that, depending on the user's choice inputs int, double or string variable. If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. The program must show the value of that variable as a console output. Use switch statement.

using System;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1) int\n2) double\n3) string\n");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    int number = int.Parse(Console.ReadLine());
                    Console.WriteLine(number + 1);
                    break;
                case 2:
                    double dNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:0.00}", dNumber + 1);
                    break;
                case 3:
                    string words = Console.ReadLine();
                    words += "*";
                    Console.WriteLine(words);
                    break;
                default:
                    break;
            }
        }
    }
}
