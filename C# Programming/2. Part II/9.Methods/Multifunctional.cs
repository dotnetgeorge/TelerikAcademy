/*
 * Write a program that can solve these tasks:
 * Reverses the digits of a number
 * Calculates the average of a sequence of integers
 * Solves a linear equation a * x + b = 0
 * Create appropriate methods.
 * Provide a simple text-based menu for the user to choose which task to solve.
 * Validate the input data:
 * The decimal number should be non-negative
 * The sequence should not be empty
 * a should not be equal to 0

*/
using System;

class Multifunctional
{
    static void Main(string[] args)
    {
        int select = 0;

        do {
            Console.WriteLine(new string('-', 14));
            Console.WriteLine("\t1.Reverse the digits of a number.");
            Console.WriteLine("\t2.Calculates the average of a sequence of integers");
            Console.WriteLine("\t3.Solves a linear equation a * x + b = 0");
            Console.Write("\tYour choice: ");
            select = int.Parse(Console.ReadLine());
        } while(select < 1 || select > 3);
        switch (select)
        {
            case 1:
                Console.Write("Enter number to be reversed: ");
                int number = int.Parse(Console.ReadLine());
                int result = ReverseDigits(number);
                Console.WriteLine("Result: " + result);
                break;
            case 2:
                float aos = AverageOfSequence();
                Console.WriteLine(aos);
                break;
            case 3:
                LinearEquation();
                break;
            default:
                Console.WriteLine("Error!");
                break;
        }
    }

    static int ReverseDigits(int number)
    {
        int reversed = 0;
        int c = 0;
        while (number != 0)
        {
            c = number % 10;
            reversed = (10 * reversed) + c;
            number /= 10;
        }
        return reversed;
    }

    static float AverageOfSequence()
    {
        Console.Write("Length of numbers: ");
        int length = int.Parse(Console.ReadLine());
        int[] numbers = new int[length]; ;
        for (int i = 0; i < length; i++)
        {
            Console.Write("{0}: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int result = 0;
        foreach (var item in numbers)
        {
            result += item;
        }

        return ((float)(result / numbers.Length));
    }

    static void LinearEquation()
    {
        float first = 0;
        do
        {
            Console.Write("Enter A: ");
            first = float.Parse(Console.ReadLine());
        } while (first == 0);

        Console.Write("Enter B: ");
        float second = float.Parse(Console.ReadLine());

        float result = (-second) / first;

        Console.WriteLine("X is {0:0.00}", result);
    }
}