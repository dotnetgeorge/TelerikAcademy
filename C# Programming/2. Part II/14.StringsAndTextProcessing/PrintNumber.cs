/*
 * Write a program that reads a number and prints it as a decimal number, 
 * hexadecimal number, percentage and in scientific notation.
 * Format the output aligned right in 15 symbols.
 */
using System;
using System.Globalization;

class PrintNumber
{
    static void Main(string[] args)
    {
        string left = "";
        Console.Write("Number:");
        double number = double.Parse(Console.ReadLine());
        string hexadecimal = Convert.ToString((int)number, 16);

        double percentage = number / 100;

        Console.WriteLine(left.PadLeft(15, ' ') + "" + number);
        Console.WriteLine(left.PadLeft(15, ' ') + "" + hexadecimal);
        Console.WriteLine(left.PadLeft(15, ' ') + "" + percentage);
        Console.WriteLine(left.PadLeft(15, ' ') + "" + number.ToString("G2", CultureInfo.InvariantCulture));
    }
}