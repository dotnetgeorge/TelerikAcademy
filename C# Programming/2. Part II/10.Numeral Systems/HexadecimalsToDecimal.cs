//Write a program to convert hexadecimal numbers to their decimal representation.

using System;

class HexadecimalsToDecimal
{
    static void Main(string[] args)
    {
        Console.Write("Numbers: ");
        int numbers = int.Parse(Console.ReadLine());

        int[] dec = new int[numbers];

        for (int i = 0; i < numbers; i++)
        {
            Console.Write("Hexadecimal number: ");
            string hex = Console.ReadLine();

            dec[i] = Convert.ToInt32(hex, 16);
        }
        for (int i = 0; i < numbers; i++)
        {
            Console.WriteLine("Decimal number: " + dec[i]);
        }
    }
}
