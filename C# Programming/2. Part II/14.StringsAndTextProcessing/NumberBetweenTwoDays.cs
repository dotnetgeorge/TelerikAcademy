/*
 * Write a program that reads two dates in the format: day.month.year 
 * and calculates the number of days between them.
 * Example:
 * Enter the first date: 27.02.2006
 * Enter the second date: 3.03.2004
 * Distance: 4 days
 */
using System;
using System.Globalization;

class NumberBetweenTwoDays
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first day: ");
        DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture);
        Console.Write("Enter the second day: ");
        DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture);
        if (firstDate.Month > secondDate.Month)
        {
            Console.WriteLine((firstDate - secondDate).TotalDays);
        }
        else if (secondDate.Month > firstDate.Month)
        {
            Console.WriteLine((secondDate - firstDate).TotalDays);
        }
        else
        {
            Console.WriteLine("Dates are equal.");
        }
    }
}