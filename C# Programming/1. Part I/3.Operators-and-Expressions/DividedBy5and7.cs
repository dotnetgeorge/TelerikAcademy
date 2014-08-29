//Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

using System;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool number = true;
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine((value % 7 == 0) && (value % 5 == 0) ? number : number = false);
        }
    }
}
