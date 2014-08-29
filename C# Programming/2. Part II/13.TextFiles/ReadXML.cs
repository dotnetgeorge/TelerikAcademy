/*
 * Write a program that extracts from given XML file all the text without the tags. Example:
 * <?xml version="1.0"><student><name>Pesho</name><age>21</age>
 * <interests count="3"><interest> Games</instrest><interest>C#</instrest>
 * <interest> Java</instrest></interests></student>
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

class ReadXML
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Path to xml file:");
            string path = @Console.ReadLine();
            XmlTextReader reader = new XmlTextReader(@path);

            List<string> fileText = new List<string>();
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Text:
                        fileText.Add(reader.Value);
                        break;
                }
            }
            foreach (var item in fileText)
            {
                Console.WriteLine(item);
            }
        }
        catch (XmlException xe)
        {
            Console.Error.WriteLine(xe.Message);
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
    }
}