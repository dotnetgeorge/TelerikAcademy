//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

using System;

class IsLeapYear
{
    static void Main(string[] args)
    {
        Console.Write("Write year: ");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine("It is leap year {0} ? {1} ", year, DateTime.IsLeapYear(year));
    }
}