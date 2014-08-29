/*
 * Write a program that reads a rectangular matrix of size N x M
 * and finds in it the square 3 x 3 that has maximal sum of its elements.
*/
using System;

namespace MaximumSum3x3
{
    class MaximumSum3x3
    {
        static void Main(string[] args)
        {
            Console.Write("N=");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("M=");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;


            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("matrix[{0},{1}]=", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }

            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 2,col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (bestSum < sum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }
            Console.WriteLine("Best platform is : ");
            Console.WriteLine(" {0} {1} {2}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1], matrix[bestRow, bestCol + 2]);
            Console.WriteLine(" {0} {1} {2}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 1, bestCol + 2]);
            Console.WriteLine(" {0} {1} {2}", matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1], matrix[bestRow + 2, bestCol + 2]);
            Console.WriteLine("Sum of matrix is " + bestSum);
        }
    }
}
