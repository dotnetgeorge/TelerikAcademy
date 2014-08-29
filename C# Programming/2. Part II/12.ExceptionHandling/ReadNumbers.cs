/*
 * Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
 * If an invalid number or non-number text is entered, the method should throw an exception. 
 * Using this method write a program that enters 10 numbers:
 * a1, a2, … a10, such that 1 < a1 < … < a10 < 100
 */
using System;

class ReadNumbers
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Start=");
            int start = int.Parse(Console.ReadLine());
            Console.Write("End=");
            int end = int.Parse(Console.ReadLine());
            ReadNumber(start, end);
        }
        catch (FormatException fe)
        {
            Console.Error.WriteLine(fe.Message);
        }
    }
    static void ReadNumber(int start, int end)
    {
        try
        {
            int count = 1;
            for (int i = start; i <= end; i++)
            {
                Console.Write("Enter {0} number: ", count);
                int number = int.Parse(Console.ReadLine());
                count++;
            }
        }
        catch (FormatException fe)
        {
            Console.Error.WriteLine(fe.Message);
        }
    }
}