/*
 * Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExtractPalindromes
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Path:");
            string path = @Console.ReadLine();
            string text = "";

            StreamReader reader = new StreamReader(@path);
            using (reader)
            {
                text = reader.ReadToEnd();
            }

            char[] pattern = new char[] { ' ', ',', '\n', '\r' };
            var elements = text.Split(pattern, StringSplitOptions.RemoveEmptyEntries);

            
            foreach (string element in elements)
            {
                bool sameChar = true;
                for (int j = 0; j < (element.Length / 2); j++)
                {
                    if (element[j] != element[element.Length - 1 - j])
                    {
                        sameChar = false;
                        break;
                    }
                }
                if (sameChar && element.Length > 1)
                {
                    Console.WriteLine(element);
                }
            }
        }
        catch (ArgumentException ae)
        {
            Console.Error.WriteLine(ae.Message);
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