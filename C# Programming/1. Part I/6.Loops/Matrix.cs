//Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:


using System;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            do
            {
                number = int.Parse(Console.ReadLine());
            } while (number > 20);

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number ; j++)
                {
                    Console.Write(i + j + 1);
                }
                Console.WriteLine();
            }
        }
    }
}
