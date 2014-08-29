/*
 * Write a program that replaces in a HTML document given as string
 * all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL]. 
 * Sample HTML fragment:
 * <p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. 
 * Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
 * 
 * <p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course. 
 * Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>
 */
using System;
using System.Collections.Generic;
using System.IO;

class ConvertHTMLTag
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Path:");
            string path = @Console.ReadLine();

            List<string> htmlFile = new List<string>();

            StreamReader reader = new StreamReader(@path);
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    htmlFile.Add(line);
                    line = reader.ReadLine();
                }
            }

            for (int i = 0; i < htmlFile.Count; i++)
            {
                if (htmlFile[i].Contains("<a href=\""))
                {
                    htmlFile[i] = htmlFile[i].Replace("<a href=\"", "[URL=");
                }
                if (htmlFile[i].Contains("\">"))
                {
                    htmlFile[i] = htmlFile[i].Replace("\">", "]");
                }
                if (htmlFile[i].Contains("</a>"))
                {
                    htmlFile[i] = htmlFile[i].Replace("</a>", "[/URL]");
                }
            }

            StreamWriter writer = new StreamWriter(@path);
            using (writer)
            {
                foreach (var item in htmlFile)
                {
                    writer.WriteLine(item);
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