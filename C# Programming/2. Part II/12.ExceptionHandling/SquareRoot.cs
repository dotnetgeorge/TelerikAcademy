/*
 *Write a program that reads an integer number and calculates and prints its square root. 
 *If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". 
 *Use try-catch-finally.
*/
using System;

class SquareRoot
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("N = ");
            int number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine(Math.Sqrt(number));
            }
            else
            {
                Console.Error.WriteLine("Invalid number");
            }
        }
        catch (FormatException)
        {
            Console.Error.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}