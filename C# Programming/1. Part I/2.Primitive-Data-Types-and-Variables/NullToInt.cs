//Create a program that assigns null values to an integer and to double variables. Try to print them on the console, try to add some values or the null literal to them and see the result.

using System;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            int? first = null;
            double? second = null;
            Console.WriteLine(first + "\n" + second);
            first = 4;
            second = 45.87;
            Console.WriteLine(first + "\n" + second);
        }
    }
}
