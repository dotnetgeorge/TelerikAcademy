/*
 * Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini),
 * reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). 
 * Be sure to catch all possible exceptions and print user-friendly error messages.
*/
using System;
using System.IO;

class ReadFile
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter directory and file to be read: ");
            string path = @Console.ReadLine();

            StreamReader reader = new StreamReader(@path);
            using (reader)
            {
                string file = reader.ReadToEnd();
                Console.WriteLine(file);
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
    }
}