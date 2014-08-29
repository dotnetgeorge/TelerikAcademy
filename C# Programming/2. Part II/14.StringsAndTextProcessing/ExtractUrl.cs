/*
 * Write a program that parses an URL address given in the format:
 * [protocol]://[server]/[resource]
 * and extracts from it the [protocol], [server] and [resource] elements.
 * For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
 * [protocol] = "http"
 * [server] = "www.devbg.org"
 * [resource] = "/forum/index.php"
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExtractUrl
{
    static void Main(string[] args)
    {
        Console.Write("URL:");
        string url = Console.ReadLine();

        int indexProtocol = url.IndexOf("://");
        string protocol = url.Substring(0, indexProtocol);

        int indexServer = url.IndexOf("/", indexProtocol + 3);
        int serverLength = (indexServer - 1) - (indexProtocol + 2);
        string server = url.Substring(indexProtocol + 3, serverLength);

        string resource = url.Substring(indexServer);
        Console.WriteLine("[protocol] = " + protocol);
        Console.WriteLine("[server] = " + server);
        Console.WriteLine("[resource] = " + resource);
    }
}