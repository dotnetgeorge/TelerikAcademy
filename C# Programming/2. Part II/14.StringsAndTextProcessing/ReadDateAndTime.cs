/*
*Write a program that reads a date and time given in the format: 
* day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes 
*(in the same format) along with the day of week in Bulgarian.
*/
using System;
using System.Globalization;


class ReadDateAndTime
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Write Date(in format dd.mm.yyyy hour:minute:second):");
            string date = Console.ReadLine();
            DateTime result = DateTime.ParseExact(date, "d.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            result = result.AddHours(6.30);
            Console.WriteLine(result.ToString("G"));
        }
        catch (FormatException fe)
        {
            Console.Error.WriteLine(fe.Message);
        }
    }
}
