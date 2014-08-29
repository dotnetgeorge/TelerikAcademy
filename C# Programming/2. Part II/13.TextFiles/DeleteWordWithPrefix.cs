/*
 * Write a program that deletes from a text file all words that start with the prefix "test".
 * Words contain only the symbols 0...9, a...z, A…Z, _.
 */
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class DeleteWordWithPrefix
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Path to file:");
            string path = @Console.ReadLine();

            List<string> text = new List<string>();

            StreamReader reader = new StreamReader(@path);
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    text.Add(line);
                    line = reader.ReadLine();
                }
            }

            List<string> result = new List<string>();
            for (int i = 0; i < text.Count; i++)
            {
                char[] remove = new char[] { ' ', ','};
                string[] elements = text[i].Split(remove, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < elements.Length; j++)
                {
                    if (!(elements[j].StartsWith("test")))
                    { 
                        result.Add(elements[j]);
                    }
                }
            }
            StreamWriter writer = new StreamWriter(@path);
            using (writer)
            {
                foreach (var item in result)
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
    }
}