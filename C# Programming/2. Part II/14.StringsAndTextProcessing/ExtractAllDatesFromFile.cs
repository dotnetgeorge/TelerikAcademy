/*
 * Write a program that extracts from a given text all dates
 * that match the format DD.MM.YYYY. 
 * Display them in the standard date format for Canada.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;

class ExtractAllDatesFromFile
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Path:");
            string path = @Console.ReadLine();

            List<string> file = new List<string>();
            List<DateTime> dates = new List<DateTime>();

            StreamReader reader = new StreamReader(@path);
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    file.Add(line);
                    line = reader.ReadLine();
                }
            }
            for (int i = 0; i < file.Count; i++)
            {
                DateTime date;
                foreach (Match item in Regex.Matches(file[i], @"\b\d{2}.\d{2}.\d{4}\b"))
                {
                    if (DateTime.TryParseExact(item.Value, "dd.MM.yyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                    {
                        Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
                    }
                }
                
                
            }
        }
        catch (ArgumentException ae)
        {
            Console.Error.WriteLine(ae.Message);
        }
        catch (FormatException fe)
        {
            Console.Error.WriteLine(fe.Message);
        }
        catch (FileLoadException fle)
        {
            Console.Error.WriteLine(fle.Message);
        }
        catch (FileNotFoundException fnfe)
        {
            Console.Error.WriteLine(fnfe.Message);
        }
        catch (AccessViolationException ave)
        {
            Console.Error.WriteLine(ave.Message);
        }
    }
}