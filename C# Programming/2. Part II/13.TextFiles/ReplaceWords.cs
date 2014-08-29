/*
 * Modify the solution of the previous problem to replace only whole words (not substrings).
 */
using System;
using System.IO;
using System.Collections.Generic;

class ReplaceWords
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Path to file:");
            string path = @Console.ReadLine();
            Console.Write("Replace word:");
            string old = Console.ReadLine();
            Console.Write("With:");
            string now = Console.ReadLine();

            List<string> list = new List<string>();

            StreamReader reader = new StreamReader(@path);

            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    list.Add(line);
                    line = reader.ReadLine();
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Contains(old))
                {
                    list[i] = list[i].Replace(old, now);
                }
            }
            StreamWriter writer = new StreamWriter(@path);
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