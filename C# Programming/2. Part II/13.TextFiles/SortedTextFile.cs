/*
 * Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. Example:
	Ivan			George
	Peter			Ivan
	Maria			Maria
	George			Peter
 */
using System;
using System.IO;
using System.Collections.Generic;

class SortedTextFile
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Path of file:");
            string path = @Console.ReadLine();

            StreamReader reader = new StreamReader(path);
            List<string> list = new List<string>();

            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    list.Add(line);
                    line = reader.ReadLine();
                }
            }
            list.Sort();

            StreamWriter writer = new StreamWriter("Sorted.txt");
            using (writer)
            {
                foreach (var item in list)
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