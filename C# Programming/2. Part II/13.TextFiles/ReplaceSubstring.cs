/*
 *Write a program that replaces all occurrences of 
 *the substring "start" with the substring "finish" in a text file. 
 *Ensure it will work with large files (e.g. 100 MB).
 *
 *It will work for large files if we use StreamBuilder
 */
using System;
using System.IO;
using System.Collections.Generic;

class ReplaceSubstring
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Path to file:");
            string path = @Console.ReadLine();

            List<string> replacedText = new List<string>();

            StreamReader reader = new StreamReader(@path);

            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    replacedText.Add(line);
                    line = reader.ReadLine();
                }
            }

            for (int i = 0; i < replacedText.Count; i++)
            {
                if (replacedText[i].Contains("start") == true)
                {
                    replacedText[i] = replacedText[i].Replace("start", "finish");
                }
            }

            StreamWriter writer = new StreamWriter(@path);

            using (writer)
            {
                foreach (var item in replacedText)
                {
                    writer.WriteLine(item);
                }
            }
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
        catch (UnauthorizedAccessException uae)
        {
            Console.Error.WriteLine(uae.Message);
        }
        catch (OutOfMemoryException oome)
        {
            Console.Error.WriteLine(oome.Message);
        }
    }
}