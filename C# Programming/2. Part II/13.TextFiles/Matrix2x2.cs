/*
 * Write a program that reads a text file containing a square matrix of numbers and
 * finds in the matrix an area of size 2 x 2 with a maximal sum of its elements. 
 * The first line in the input file contains the size of matrix N. 
 * Each of the next N lines contain N numbers separated by space. 
 * The output should be a single number in a separate text file. Example:
 * 4
 * 2 3 3 4
 * 0 2 3 4			
 * 3 7 1 2  3 7 -\
 * 4 3 3 2  4 3 -/ 17

 */
using System;
using System.IO;
using System.Collections.Generic;


class Matrix2x2
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Path to file:");
            string path = @Console.ReadLine();

            int[,] matrix;

            StreamReader reader = new StreamReader(@path);
            using (reader)
            {
                string line = reader.ReadLine();
                int length = int.Parse(line);
                matrix = new int[length, length];
                for (int row = 0; row < length; row++)
                {
                    line = reader.ReadLine();
                    string[] elements = line.Split(' ');
                    for (int col = 0; col < length; col++)
                    {
                        matrix[row, col] = int.Parse(elements[col]);
                    }
                }
            }
            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (bestSum < sum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }
            Console.WriteLine("Best matrix is:");
            Console.WriteLine(" {0} {1}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1]);
            Console.WriteLine(" {0} {1}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1]);
            Console.WriteLine("Best sum is:" + bestSum);
        }
        catch (FileLoadException fle)
        {
            Console.Error.WriteLine(fle.Message);
        }
        catch (FileNotFoundException fnfe)
        {
            Console.Error.WriteLine(fnfe.Message);
        }
        catch (AccessViolationException ave)
        {
            Console.Error.WriteLine(ave.Message);
        }
    }
}