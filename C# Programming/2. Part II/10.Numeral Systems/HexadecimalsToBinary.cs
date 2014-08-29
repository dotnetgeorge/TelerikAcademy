//Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;

class HexadecimalsToBinary
{
    static void Main(string[] args)
    {
        Console.Write("Numbers: ");
        int numbers = int.Parse(Console.ReadLine());

        for (int i = 0; i < numbers; i++)
        {
            Console.Write("Hexadecimal: ");
            string hex = Console.ReadLine();
            string binary = Convert.ToString(Convert.ToInt32(hex, 16), 2);
            Console.WriteLine("\tBinary number: " + binary);
        }
    }
}
