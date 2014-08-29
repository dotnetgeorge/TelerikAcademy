/*
 * Write a program that fills and prints a matrix of size (n, n) as shown below:
 * (examples for n = 4)
 * 1 12 11 10
 * 2 13 16  9
 * 3 14 15  8
 * 4  5  6  7 
 */
using System;
    class FillFourthMatrix
    {
        static void Main(string[] args)
        {
            Console.Write("Length:");
            int length = int.Parse(Console.ReadLine());

            int[,] matrix = new int[length, length];

            int add = 1, counter = length, current = -length, sum = -1;

            do
            {
                current = -1 * current / length;
                for (int i = 0; i < counter; i++)
                {
                    sum += current;
                    matrix[sum / length, sum % length] = add;
                    add++;
                }
                current *= length;
                counter--;
                for (int i = 0; i < counter; i++)
                {
                    sum += current;
                    matrix[sum / length, sum % length] = add;
                    add++;
                }

            } while (counter > 0);

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }