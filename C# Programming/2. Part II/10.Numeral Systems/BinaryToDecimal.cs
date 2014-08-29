//Write a program to convert binary numbers to their decimal representation.

using System;

class BinaryToDecimal
{
    static void Main(string[] args)
    {
        Console.Write("Binary number: ");
        string binary = Console.ReadLine();
        int number = Convert.ToInt32(binary, 2);
        Console.WriteLine(number);
    }
}
