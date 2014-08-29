//Write a method that reverses the digits of given decimal number. Example: 256 -> 652

using System;

class ReverseNumber
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Reverse(number);
    }

    static void Reverse(int number)
    {
        int reversed = 0;
        int c = 0;
        while (number != 0)
        {
            c = number % 10;
            reversed = (10 * reversed) + c;
            number /= 10;
        }
        Console.WriteLine(reversed);
    }
}