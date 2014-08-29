//Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

class Print10RandomValues
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(rnd.Next(100, 200));
        }
    }
}
