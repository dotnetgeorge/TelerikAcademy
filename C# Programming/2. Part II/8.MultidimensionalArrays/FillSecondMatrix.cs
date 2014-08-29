/*
 * Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
 * 1 8 9 16
 * 2 7 10 15
 * 3 6 11 14
 * 4 5 12 13
 */
using System;

class FillSecondMatrix
{
    static void Main(string[] args)
    {
        Console.Write("N=");
        int length = int.Parse(Console.ReadLine());

        int[,] matrix = new int[length, length];

        int count = 0;
        int fill = 1;
        for (int col = 0; col < length; col++)
        {
            count = col + 1;
            if (count % 2 != 0)
            {
                for (int row = 0; row < length; row++)
                {
                    matrix[row, col] = fill;
                    fill++;
                }
            }
            else
            {
                for (int row = length - 1; row >= 0; row--)
                {
                    matrix[row, col] = fill;
                    fill++;
                }
            }
        }

        for (int row = 0; row < length; row++)
        {
            for (int col = 0; col < length; col++)
            {
                Console.Write(matrix[row,col] + " ");
            }
            Console.WriteLine();
        }
    }
}