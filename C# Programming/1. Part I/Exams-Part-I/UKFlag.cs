//Problem - http://bgcoder.com/Contests/Practice/DownloadResource/272
using System;

class UKFlag
{
    static void Main()
    {
        int lines;
        do
        {
            lines = int.Parse(Console.ReadLine());
        } while ((lines % 2 == 0) && (lines < 5) || (lines > 79));

        int innerDots = lines / 2 - 1;
        int outerDots = 0;

        for (int i = 0; i < lines / 2; i++)
        {
            Console.Write(new string('.', outerDots));
            Console.Write("\\");
            Console.Write(new string('.', innerDots));
            Console.Write("|");
            Console.Write(new string('.', innerDots));
            Console.Write("/");
            Console.Write(new string('.', outerDots));
            Console.WriteLine();
            outerDots++;
            innerDots--;
        }
        Console.Write(new string('-', lines/ 2));
        Console.Write("*");
        Console.WriteLine(new string('-', lines / 2));

        innerDots = 0;
        outerDots = lines / 2 - 1;
        for (int i = 0; i < lines / 2; i++)
        {
            Console.Write(new string('.', outerDots));
            Console.Write("/");
            Console.Write(new string('.', innerDots));
            Console.Write("|");
            Console.Write(new string('.', innerDots));
            Console.Write("\\");
            Console.Write(new string('.', outerDots));
            Console.WriteLine();
            outerDots--;
            innerDots++;
        }
    }
}
