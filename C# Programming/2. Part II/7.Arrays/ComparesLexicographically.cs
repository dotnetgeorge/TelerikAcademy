//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class ComparesLexicographically
{
    static void Main(string[] args)
    {
        Console.Write("Length of array: ");
        int length = int.Parse(Console.ReadLine());
        char[] firstArr = new char[length];
        char[] secondArr = new char[length];

        int first = 0, second = 0;

        for (int i = 0; i < length; i++)
        {
            Console.Write("Fill first array[{0}]: ", i + 1);
            firstArr[i] = char.Parse(Console.ReadLine());
        }
        for (int i = 0; i < length; i++)
        {
            Console.Write("Fill second array[{0}]: ");
            secondArr[i] = char.Parse(Console.ReadLine());
        }

        for (int i = 0; i < length; i++)
        {
            first += (int)firstArr[i];
            second += (int)secondArr[i];
        }
        if (first == second)
        {
            Console.WriteLine("Arrays are with same characters.");
        }
        else
        {
            Console.WriteLine(first < second ? "First array is near lexicographycall." : "Second array is near lexicographycall.");
        }
    }
}