/*
 *Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg)
 *and stores it the current directory. Find in Google how to download files in C#. 
 *Be sure to catch all exceptions and to free any used resources in the finally block.
 */
using System;
using System.Net;

class DownloadFile
{
    static void Main(string[] args)
    {
        WebClient web = new WebClient();
        try
        {
            Console.Write("Enter url address of file:");
            string url = Console.ReadLine();
            int index = url.LastIndexOf("/");
            string name = url.Substring(index + 1);

            web.DownloadFile(url, name);
            Console.WriteLine("File {0} downloaded successfully.", name);
        }
        catch (WebException we)
        {
            Console.Error.WriteLine(we.Message);
        }
        catch (FormatException fe)
        {
            Console.Error.WriteLine(fe.Message);
        }
        catch (Exception e)
        {
            Console.Error.WriteLine(e.Message);
        }
    }
}