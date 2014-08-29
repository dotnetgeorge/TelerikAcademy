//Write a program that reads two arrays from the console and compares them element by element.

using System;

class Compares2Arrays
{
    static void Main(string[] args)
    {
        bool isSame = true;

        Console.Write("Length of arrays: ");
        int length = int.Parse(Console.ReadLine());

        string[] firstArr = new string[length];
        string[] secondArr = new string[length];

        for (int i = 0; i < length; i++)
        {
            Console.Write("First Array[{0}]: ", i + 1);
            firstArr[i] = Console.ReadLine();
        }
        for (int i = 0; i < length; i++)
        {
            Console.Write("Second Array[{0}]: ", i + 1);
            secondArr[i] = Console.ReadLine();
        }

        for (int i = 0; i < length; i++)
        {
            if (firstArr[i] != secondArr[i])
            {
                isSame = false;
            }
        }

        Console.WriteLine("Is elements in arrays same? " + isSame);
    }
}
