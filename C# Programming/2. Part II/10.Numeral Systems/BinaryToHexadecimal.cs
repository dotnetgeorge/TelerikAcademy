//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;

class BinaryToHexadecimal
{
    static void Main(string[] args)
    {
        Console.Write("Numbers: ");
        int numbers = int.Parse(Console.ReadLine());

        for (int i = 0; i < numbers; i++)
        {
            Console.Write("Binary: ");
            string binary = Console.ReadLine();

            string hexadecimal = Convert.ToString(Convert.ToInt32(binary, 2), 16);
            Console.WriteLine("\tHexadecimal: " + hexadecimal);
        }
    }
}
