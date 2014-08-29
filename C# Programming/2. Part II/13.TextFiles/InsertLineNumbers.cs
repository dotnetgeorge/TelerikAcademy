/*
 * Write a program that reads a text file and inserts line numbers in front of each of its lines. 
 * The result should be written to another text file.
 */
using System;
using System.IO;
using System.Collections.Generic;

class InsertLineNumbers
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Path to file:");
            string path = @Console.ReadLine();
            Console.Write("Name of new file:");
            string fileName = @Console.ReadLine();

            StreamReader reader = new StreamReader(path);
            StreamWriter writer = new StreamWriter(fileName);

            List<string> list = new List<string>();

            using (reader)
            {
                string line = reader.ReadLine();
                int count = 1;
                while (line != null)
                {
                    string write = count + ". " + line;
                    list.Add(write);
                    Console.WriteLine(write);
                    line = reader.ReadLine();
                    count++;
                }
            }
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