//Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2  value=1.

using System;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int bit = int.Parse(Console.ReadLine());
            int mask = 1 << bit;
            int result = number & mask;
            result >>= bit;
            Console.WriteLine(result);
        }
    }
}
