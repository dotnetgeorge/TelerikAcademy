//Write a program to convert decimal numbers to their hexadecimal representation.

using System;


class DecimalsToHex
{
    static void Main(string[] args)
    {
        Console.Write("Numbers: ");
        int numbers = int.Parse(Console.ReadLine());

        string[] hex = new string[numbers];

        for (int i = 0; i < numbers; i++)
        {
            Console.Write("Decimal number: ");
            int number = int.Parse(Console.ReadLine());

            hex[i] = Convert.ToString(number, 16);
        }
        for (int i = 0; i < numbers; i++)
        {
            Console.WriteLine("Hexadecimal numbers: " + hex[i]);
        }
    }
}