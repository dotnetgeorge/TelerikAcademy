/*
 * *Write a class Matrix, to holds a matrix of integers. 
 * Overload the operators for adding, subtracting and multiplying of matrices, 
 * indexer for accessing the matrix content and ToString().
 */
using System;

namespace ClassMatrix
{
    public class Matrix
    {
        private int[,] matrix;

        public Matrix()
        { }
        public Matrix(int[,] matrix)
        {
            this.matrix = matrix;
        }

        public int this[int indexRow, int indexCol]
        {
            get
            {
                return this.matrix[indexRow, indexCol];
            }
            set
            {
                this.matrix[indexRow, indexCol] = value;
            }
        }

        public void Add(int row, int col, int value)
        {
            if (this.matrix.GetLength(0) <= row || col >= this.matrix.GetLength(1))
            {
                IndexOutOfRangeException ioore = new IndexOutOfRangeException();
                Console.Error.WriteLine(ioore.Message);
            }
            matrix[row, col] = value;
        }

        public int[,] Substract(int startRow, int startCol, int endRow, int endCol)
        {
            if ((startRow > this.matrix.GetLength(0)) || (endRow > this.matrix.GetLength(0)) || (startCol > this.matrix.GetLength(1)) || (endCol > this.matrix.GetLength(1)))
            {
                throw new IndexOutOfRangeException("Check entered rows/cols because one or many of then is bigger than matrix rows/cols!");
            }

            int[,] result = new int[endRow - startRow, endCol - startCol];
            int indexRow = 0, indexCol = 0;
            for (int row = startRow; row < endRow; row++)
            {
                for (int col = startCol; col < endCol; col++)
                {
                    result[indexRow, indexCol] = this.matrix[row, col];
                    indexCol++;
                }
                indexRow++;
            }

            return result;
        }

        public void MultiplyingMatrices(int[,] multMatrix)
        {
            if (multMatrix.GetLength(0) > this.matrix.GetLength(0) || this.matrix.GetLength(1) < multMatrix.GetLength(1))
            {
                throw new IndexOutOfRangeException("Multiplying matrix Row or Col is bigger than first matrix!");
            }
            for (int row = 0; row < multMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < multMatrix.GetLength(1); col++)
                {
                    this.matrix[row, col] *= multMatrix[row, col];
                }
            }
        }

        public override string ToString()
        {
            string result = "";
            for (int row = 0; row < this.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < this.matrix.GetLength(1); col++)
                {
                    result += this.matrix[row, col] + " ";
                }
                result += "\n";
            }
            return result;
        }
    }
}
