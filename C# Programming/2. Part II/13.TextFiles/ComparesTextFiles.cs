/*
 * Write a program that compares two text files line by line and prints the number of lines that are the same
 * and the number of lines that are different. Assume the files have equal number of lines.
 */
using System;
using System.IO;
using System.Collections.Generic;

class ComparesTextFiles
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Path to first file:");
            string firstPath = @Console.ReadLine();
            Console.Write("Path to second file:");
            string secondPath = @Console.ReadLine();

            StreamReader firstReader = new StreamReader(@firstPath);
            StreamReader secondReader = new StreamReader(@secondPath);

            List<string> first = new List<string>();
            List<string> second = new List<string>();

            int sameLines = 0;
            int differentLines = 0;
            int length = 0;
            int additionalLines = 0;

            using (firstReader)
            {
                string line = firstReader.ReadLine();
                while (line != null)
                {
                    first.Add(line);
                    line = firstReader.ReadLine();
                }
            }
            using (secondReader)
            {
                string line = secondReader.ReadLine();
                while (line != null)
                {
                    second.Add(line);
                    line = secondReader.ReadLine();
                }
            }


            if (first.Count > second.Count)
            {
                length = second.Count;
                additionalLines = first.Count - second.Count;
            }
            else if (second.Count > first.Count)
            {
                length = first.Count;
                additionalLines = second.Count - first.Count;
            }
            for (int i = 0; i < length; i++)
            {
                if (first[i] == second[i])
                {
                    sameLines++;
                }
                else
                {
                    differentLines++;
                }
            }
            Console.WriteLine("{0} same lines.", sameLines);
            Console.WriteLine("{0} different lines.", differentLines + additionalLines);

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