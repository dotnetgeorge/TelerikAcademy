/*
 * Write a program that extracts from given HTML file its title (if available), 
 * and its body text without the HTML tags. Example:
 */
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class HTMLToText
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Path to HTML file:");
            string path = @Console.ReadLine();
            Console.Write("Name of text file:");
            string fileName = @Console.ReadLine();

            List<string> htmlFile = new List<string>();
            List<string> textResult = new List<string>();

            StreamReader reader = new StreamReader(@path);
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    htmlFile.Add(line);
                    line = reader.ReadLine();
                }
            }
            //Regex regex = new Regex(@"(?></?\w+)(?>(?:[^>'""]+|'[^']*'|""[^""]*"")*)>");
            for (int i = 0; i < htmlFile.Count; i++)
            {
                if (Regex.IsMatch(htmlFile[i].ToLower(), "<title>(.*?)</title>"))
                {
                    string title = Regex.Replace(htmlFile[i], "<title>(.*?)</title>", m => m.Groups[1].Value);
                    title = "Title: " + title;
                    textResult.Add(title);
                }
                else
                {
                    string item = RemoveTags(htmlFile[i]);
                    textResult.Add(item);
                }
            }
            StreamWriter writer = new StreamWriter(@fileName);
            using (writer)
            {
                foreach (var item in textResult)
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

    static string RemoveTags(string html)
    {
        char[] arr = new char[html.Length];
        int arrIndex = 0;
        bool inside = false;

        for (int i = 0; i < html.Length; i++)
        {
            char ch = html[i];

            if (ch == '<')
            {
                inside = true;
                continue;
            }
            if (ch == '>')
            {
                inside = false;
                continue;
            }
            if (!inside)
            {
                arr[arrIndex] = ch;
                arrIndex++;
            }
        }

        return new string(arr, 0, arrIndex);
    }
}