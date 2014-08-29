//Problem - http://bgcoder.com/Contests/Practice/DownloadResource/13
using System;

class FirTree
{
    static void Main(string[] args)
    {
        int lines;

        do
        {
            lines = int.Parse(Console.ReadLine());
        } while ((lines < 4) && (lines > 100));
            
        lines--;
        int formula = 2 * (lines - 1) + 1;
        for (int i = 0; i < lines; i++)
        {
            for (int j = 0; j < formula; j++)
            {
                if ((j >= lines - 1 - i) && (j <= lines - 1 + i))
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
        for (int i = 0; i < formula; i++)
        {
            if (i == lines - 1)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(".");
            }
        }
        Console.WriteLine();
    }
}
