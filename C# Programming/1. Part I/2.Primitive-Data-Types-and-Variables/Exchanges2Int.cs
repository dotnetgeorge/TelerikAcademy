//Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

using System;
namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = 5;
            int two = 10;

            int temp = one;
            one = two;
            two = temp;

            Console.WriteLine(one + "\n" + two);
        }
    }
}