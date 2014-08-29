/*
 * Write a program that concatenates two text files into another text file.
 */
using System;
using System.Collections.Generic;
using System.IO;

class ConcatenatesTextFiles
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Path to first text file: ");
            string firstPath = @Console.ReadLine();
            Console.Write("Path to second text file: ");
            string secondPath = @Console.ReadLine();
            Console.Write("Name of concatenated file: ");
            string fileName = @Console.ReadLine();

            StreamReader firstReader = new StreamReader(@firstPath);
            StreamReader secondReader = new StreamReader(@secondPath);
            StreamWriter writer = new StreamWriter(@fileName);

            List<string> list = new List<string>();

            using (firstReader)
            {
                string line = firstReader.ReadLine();
                while (line != null)
                {
                    list.Add(line);
                    line = firstReader.ReadLine();
                }
            }
            using (secondReader)
            {
                string line = secondReader.ReadLine();
                while (line != null)
                {
                    list.Add(line);
                    line = secondReader.ReadLine();
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