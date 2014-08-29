//Write a program that finds the greatest of given 5 variables.

using System;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());
            int four = int.Parse(Console.ReadLine());
            int five = int.Parse(Console.ReadLine());

            int large = Int32.MinValue;

            if (one > two)
            {
                large = one;
            }
            if (three > large)
            {
                large = three;
            }
            if (four > large)
            {
                large = four;
            }
            if (five > large)
            {
                large = five;
            }
            Console.WriteLine(large);
        }
    }
}
