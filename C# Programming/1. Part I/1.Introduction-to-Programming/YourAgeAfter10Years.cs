//* Write a program to read your age from the console and print how old you will be after 10 years.

using System;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age after 10 years will be " + (age + 10));
            Console.ReadKey();
        }
    }
}
