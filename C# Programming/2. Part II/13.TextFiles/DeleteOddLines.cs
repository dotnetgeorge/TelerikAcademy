/*
 * Write a program that deletes from given text file all odd lines.
 * The result should be in the same file.
 */
using System;
using System.IO;
using System.Collections.Generic;

class DeleteOddLines
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Path to file:");
            string path = @Console.ReadLine();

            List<string> file = new List<string>();

            StreamReader reader = new StreamReader(@path);
            using (reader)
            {
                string line = reader.ReadLine();
                int count = 1;
                while (line != null)
                {
                    if (count % 2 == 0)
                    {
                        file.Add(line);
                    }
                    line = reader.ReadLine();
                    count++;
                }
            }

            StreamWriter writer = new StreamWriter(@path);
            using (writer)
            {
                foreach (var item in file)
                {
                    writer.WriteLine(item);
                }
            }
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