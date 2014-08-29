//Write a program to convert decimal numbers to their binary representation.

using System;

class DecimalToBinary
{
    static void Main(string[] args)
    {
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine());

        string binary = Convert.ToString(number, 2);
        Console.WriteLine(binary);
    }
}
