/*
 * Write a program for extracting all email addresses from given text.
 * All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.
 */
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class ExtractEmails
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Path:");
            string path = @Console.ReadLine();
            Console.Write("Name of file with extracted emails:");
            string fileName = @Console.ReadLine();

            List<string> oldFile = new List<string>();
            List<string> emails = new List<string>();

            StreamReader reader = new StreamReader(@path);
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    oldFile.Add(line);
                    line = reader.ReadLine();
                }
            }
            Regex regex = new Regex(@"[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            for (int i = 0; i < oldFile.Count; i++)
            {
                MatchCollection collection = regex.Matches(oldFile[i]);
                foreach (Match item in collection)
                {
                    emails.Add(item.Value.ToString());
                }
            }
            StreamWriter writer = new StreamWriter(@fileName);
            using (writer)
            {
                foreach (var item in emails)
                {
                    writer.WriteLine(item);
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