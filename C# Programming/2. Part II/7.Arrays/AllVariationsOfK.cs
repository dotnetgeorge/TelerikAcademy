/*
 * Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. 
 * Example:
 * N = 3, K = 2 -> {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}
 */
using System;

class AllVariationsOfK
{
    static int numberOfloops;
    static int iterations;
    static int[] loops;

    static void Main(string[] args)
    {
        Console.Write("N:");
        iterations = int.Parse(Console.ReadLine());
        Console.Write("K:");
        numberOfloops = int.Parse(Console.ReadLine());

        loops = new int[numberOfloops];
        Loops(0);
    }

    static void Loops(int currentLoop)
    {
        if (currentLoop == numberOfloops)
        {
            Print();
            return;
        }
        for (int i = 1; i <= iterations; i++)
        {
            loops[currentLoop] = i;
            Loops(currentLoop + 1);
        }
    }
    static void Print()
    {
        for (int i = 0; i < numberOfloops; i++)
        {
            Console.Write("{0} ", loops[i]);
        }
        Console.WriteLine();
    }
}