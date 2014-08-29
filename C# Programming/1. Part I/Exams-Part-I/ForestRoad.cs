// Problem - http://bgcoder.com/Contests/Practice/DownloadResource/3
using System;

class ForestRoad
{
    static void Main(string[] args)
    {
        int length = int.Parse(Console.ReadLine());

        for (int i = 1; i <= length; i++)
        {
            Console.Write(new string('.', i - 1));
            Console.Write(new string('*', 1));
            Console.WriteLine(new string('.', length - i));
        }
        for (int i = length - 1; i >= 1; i--)
        {
            Console.Write(new string('.', i - 1));
            Console.Write(new string('*', 1));
            Console.WriteLine(new string('.', length - i));
        }
    }
}
