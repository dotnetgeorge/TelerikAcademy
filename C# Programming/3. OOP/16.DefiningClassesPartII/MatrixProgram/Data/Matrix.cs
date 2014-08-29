namespace MatrixProgram.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Matrix<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        private int rows;
        private int cols;
        private T[,] matrix;

        public int Rows
        {
            get { return this.rows; }
        }
        public int Cols
        {
            get { return this.cols; }
        }

        public T this[int row, int col]
        {
            get
            {
                if ((row >= 0) && (row < rows) && (col >= 0) && (col < cols))
                {
                    return matrix[row, col];
                }
                else
                {
                    throw new ArgumentException(String.Format("Cell ({0}, {1}) is invalid", row, col));
                }
            }
            set
            {
                if (row >= 0 && row < rows && col >= 0 && col < cols)
                {
                    matrix[row, col] = value;
                }
                else
                {
                    throw new ArgumentException(String.Format("Cell ({0}, {1}) is invalid.", row, col));
                }
            }
        }

        public Matrix(int rows, int cols)
        {
            if (rows <= 0 || cols <= 0)
            {
                throw new ArgumentException("Rows/Cols must be greater than 0!");
            }

            this.rows = rows;
            this.cols = cols;
            this.matrix = new T[rows, cols];
        }

        public Matrix(T[,] value)
        {
            if (value == null || value.GetLength(0) == 0 || value.GetLength(1) == 0)
            {
                throw new ArgumentException("Matrix must contain at least one item.");
            }
            this.rows = value.GetLength(0);
            this.cols = value.GetLength(1);
            this.matrix = (T[,])value.Clone();
        }

        public void AddNumber(T item, int row, int col)
        {
            this.matrix[row, col] = item;
        }

        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.rows != secondMatrix.rows || firstMatrix.cols != secondMatrix.cols)
            {
                throw new ArgumentException("Matrices must have the same dimensions.");
            }

            try
            {
                Matrix<T> result = new Matrix<T>(firstMatrix.rows, firstMatrix.cols);

                for (int row = 0; row < result.rows; row++)
                {
                    for (int col = 0; col < result.cols; col++)
                    {
                        checked
                        {
                            result[row, col] = (dynamic)firstMatrix[row, col] + secondMatrix[row, col];
                        }
                    }
                }

                return result;
            }
            catch (OverflowException oe)
            {
                throw new ArgumentException(oe.Message);
            }
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.rows != secondMatrix.rows || firstMatrix.cols != secondMatrix.cols)
            {
                throw new ArgumentException("Matrices must have the same dimensions!");
            }
            try
            {
                Matrix<T> result = new Matrix<T>(firstMatrix.rows, firstMatrix.cols);

                for (int row = 0; row < result.rows; row++)
                {
                    for (int col = 0; col < result.cols; col++)
                    {
                        checked
                        {
                            result[row, col] = (dynamic)firstMatrix[row, col] - secondMatrix[row, col];
                        }
                    }
                }
                return result;
            }
            catch (OverflowException oe)
            {
                throw new ArgumentException(oe.Message);
            }
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Cols == secondMatrix.Rows && (firstMatrix.Rows > 0 && secondMatrix.Cols > 0 && firstMatrix.Cols > 0))
            {
                Matrix<T> result = new Matrix<T>(firstMatrix.Rows, secondMatrix.Cols);

                for (int row = 0; row < result.Rows; row++)
                {
                    for (int col = 0; col < result.Cols; col++)
                    {
                        result[row, col] = (dynamic)0;
                        for (int k = 0; k < firstMatrix.Cols; k++)
                        {
                            checked
                            {
                                result[row, col] = result[row, col] + (dynamic)firstMatrix[row, k] * secondMatrix[k, col];
                            }
                        }
                    }
                }

                return result;
            }
            else
            {
                throw new ArgumentException("Row on the first matrix and col on the second matrix, are with different size, multiplication cannot be done.");
            }
        }

        public static Boolean operator false(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if ((dynamic)matrix[row, col] == 0)
                    {
                        return false;
                        break;
                    }
                }
            }
            return true;
        }

        public static Boolean operator true(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if ((dynamic)matrix[row, col] == 0)
                    {
                        return false;
                        break;
                    }
                }
            }
            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Cols; col++)
                {
                    sb.Append(matrix[row, col] + " ");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
