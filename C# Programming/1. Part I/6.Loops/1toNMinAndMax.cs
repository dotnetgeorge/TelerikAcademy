//Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.


using System;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int max = int.MinValue, min = int.MaxValue;

            for (int i = 0; i < number; i++)
            {
                int loopNumber = int.Parse(Console.ReadLine());
                if (loopNumber > max)
                {
                    max = loopNumber;
                }
                if (loopNumber < min)
                {
                    min = loopNumber;
                }
            }

            Console.WriteLine("Max: {0}\nMin: {1}", max, min);
        }
    }
}
