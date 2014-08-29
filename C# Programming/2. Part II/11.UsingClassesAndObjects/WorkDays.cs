/*
 * Write a method that calculates the number of workdays between today and given date, passed as parameter.
 * Consider that workdays are all days from Monday to Friday except
 * a fixed list of public holidays specified preliminary as array.
 */
using System;
using System.Globalization;

class WorkDays
{
    static void Main()
    {
        Console.Write("Date(format: dd.mm.yyyy):");
        DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.mm.yyyy",CultureInfo.InvariantCulture);
        CountWorkDays(date);
    }
    static void CountWorkDays(DateTime date)
    {
        int day = int.Parse(date.Day.ToString());
        int month = int.Parse(date.Month.ToString());
        int year = int.Parse(date.Year.ToString());

        DateTime startDay = DateTime.Today;
        DateTime endDay = new DateTime(year, month, day);

        int time = Math.Abs((endDay - startDay).Days);
        if (startDay > endDay)
        {
            startDay = endDay;
            endDay = DateTime.Today;
        }

        DateTime[] holidays = new DateTime[] { 
            new DateTime(2013, 1, 1),
            new DateTime(2013, 2, 2)
        };
        Console.WriteLine(time);
        int workDays = 0;
        bool holiday = false;

        for (int i = 0; i < time; i++)
        {
            startDay = startDay.AddDays(1);
            if (startDay.DayOfWeek != DayOfWeek.Sunday && startDay.DayOfWeek != DayOfWeek.Saturday)
            {
                for (int j = 0; j < holidays.Length; j++)
                {
                    if (startDay == holidays[j])
                    {
                        holiday = true;
                        break;
                    }
                }
                if (!holiday)
                {
                    workDays++;
                }
                holiday = false;
            }
        }
        Console.WriteLine(workDays);

    }
}