/*
 * Write a program that removes from a text file all words listed in given another text file. 
 * Handle all possible exceptions in your methods.
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

class RemoveWords
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Path to file:");
            string firstFile = @Console.ReadLine();
            Console.Write("Path to file with word/s to remove:");
            string secondFile = @Console.ReadLine();
            Console.Write("Name of new file:");
            string fileName = @Console.ReadLine();

            List<string> oldFile = new List<string>();
            List<string> newFile = new List<string>();

            StreamReader firstReader = new StreamReader(@firstFile);
            using (firstReader)
            {
                string line = firstReader.ReadLine();
                while (line != null)
                {
                    oldFile.Add(line);
                    line = firstReader.ReadLine();
                }
            }
            StreamReader secondReader = new StreamReader(@secondFile);
            using (secondReader)
            {
                string line = secondReader.ReadLine();
                while (line != null)
                {
                    newFile.Add(line);
                    line = secondReader.ReadLine();
                }
            }

            for (int i = 0; i < oldFile.Count; i++)
            {
                for (int j = 0; j < newFile.Count; j++)
                {
                    string remove = newFile[j].ToString();
                    oldFile[i].Replace(remove, String.Empty);
                }
            }

            StreamWriter writer = new StreamWriter(@fileName);
            using (writer)
            {
                foreach (var item in oldFile)
                {
                    writer.WriteLine(item);
                }
            }
        }
        catch (AccessViolationException ave)
        {
            Console.Error.WriteLine(ave.Message);
        }
        catch (FileLoadException fle)
        {
            Console.Error.WriteLine(fle.Message);
        }
        catch (FileNotFoundException fnfe)
        {
            Console.Error.WriteLine(fnfe.Message);
        }
        catch (ArgumentOutOfRangeException aoore)
        {
            Console.Error.WriteLine(aoore.Message);
        }
        catch (ArgumentNullException ane)
        {
            Console.Error.WriteLine(ane.Message);
        }
    }
}