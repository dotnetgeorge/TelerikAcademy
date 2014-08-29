/*
 * Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
 * 1 5 9 13
 * 2 6 10 14
 * 3 7 11 15
 * 4 8 12 16
*/
using System;

class FillFirstMatrix
{
    static void Main(string[] args)
    {
        Console.Write("N=");
        int length = int.Parse(Console.ReadLine());

        int[,] matrix = new int[length, length];

        int fill = 1;
        for (int col = 0; col < length; col++)
        {
            for (int row = 0; row < length; row++)
            {
                matrix[row, col] = fill;
                fill++;
            }
        }

        for (int row = 0; row < length; row++)
        {
            for (int col = 0; col < length; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}
