//Problem - http://bgcoder.com/Contests/Practice/DownloadResource/504
using System;

class PeaceOfCake
{
    static void Main(string[] args)
    {
        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());
        long d = long.Parse(Console.ReadLine());

        long firstFraction = (b * c) + (a * d);
        long secondFraction = b * d;

        decimal result = ((decimal)firstFraction / secondFraction);

        if (result >= 1)
        {
            Console.WriteLine((long)result);
        }
        else
        {
            Console.WriteLine("{0:F20}", result);
        }
        Console.WriteLine(firstFraction + "/" + secondFraction);

    }
}
