//Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;

class OddLines
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Path:");
            string path = @Console.ReadLine();
            StreamReader reader = new StreamReader(@path);

            using (reader)
            {
                int line = 1;
                string text = reader.ReadLine();
                while (text != null)
                {
                    if (line % 2 != 0)
                    {
                        Console.WriteLine(text);
                    }
                    line++;
                    text = reader.ReadLine();
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