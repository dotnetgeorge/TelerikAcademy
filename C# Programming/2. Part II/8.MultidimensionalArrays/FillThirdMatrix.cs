/*
 * Write a program that fills and prints a matrix of size (n, n) as shown below:
 * (examples for n = 4)
 * 7 11 14 16
 * 4  8 12 15
 * 2  5  9 13
 * 1  3  6 10
 */
using System;

class FillThirdMatrix
{
    static void Main(string[] args)
    {
        Console.Write("Length:");
        int length = int.Parse(Console.ReadLine());

        int[,] matrix = new int[length, length];

        int rows = 0, cols = 0, index = 1;

        for (int i = length - 1; i >= 0; i--)
        {
            rows = i;
            cols = 0;
            while (length > rows && cols < length)
            {
                matrix[rows++, cols++] = index++;
            }
        }
        for (int i = 1; i < length; i++)
        {
            rows = i;
            cols = 0;
            while (length > rows && cols < length)
            {
                matrix[cols++, rows++] = index++;
            }
        }
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row,col] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}