/*
 * *Write a class Matrix, to holds a matrix of integers. 
 * Overload the operators for adding, subtracting and multiplying of matrices, 
 * indexer for accessing the matrix content and ToString().
 */
using System;
using ClassMatrix;

namespace ClassMatrix
{
    class ClassMatrix
    {
        static void Main(string[] args)
        {
            Work();
        }
        static void Work()
        {
            int[,] matrix = new int[0,0];
            Matrix mt = new Matrix(matrix);
            Choice();
            string choice = Console.ReadLine();
            while (choice != "end")
            {
                switch (choice)
                {
                    case "1":
                        matrix = CreateMatrix();
                        mt = new Matrix(matrix);
                        break;
                    case "2":
                        FillMatrix(matrix);
                        mt = new Matrix(matrix);
                        break;
                    case "3":
                        AccessByIndex(mt);
                        break;
                    case "4":
                        AddValue(mt);
                        break;
                    case "5":
                        MultiplyingMatrix(mt);
                        break;
                    case "6":
                        SubstractMatrix(mt);
                        break;
                    case "7":
                        PrintMatrix(mt);
                        break;
                    default:
                        Console.WriteLine("Wrong choice!\nChoose option between 1-7 or enter end to exit program.");
                        break;
                }
                Console.Write("Press any key to clear window and continue.");
                Console.ReadKey();
                Console.Clear();
                Choice();
                choice = Console.ReadLine();
            }
        }
        static void Choice()
        {
            Console.WriteLine("To end program write \"end\"(without quotes)");
            Console.WriteLine("1. Create matrix.");
            Console.WriteLine("2. Fill matrix.");
            Console.WriteLine("3. Access matrix by index.");
            Console.WriteLine("4. Add value in matrix.");
            Console.WriteLine("5. Multiplying matrix by another matrix.");
            Console.WriteLine("6. Substract matrix.");
            Console.WriteLine("7. Print matrix.");
            Console.Write("Your choice:");
        }

        static int[,] CreateMatrix()
        {
            Console.Write("Rows:");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Cols:");
            int cols = int.Parse(Console.ReadLine());
            
            int[,] matrix = new int[rows, cols];

            return matrix;
        }

        static void FillMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("matrix[{0},{1}]:", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
        }

        static void AccessByIndex(Matrix mt)
        {
            Console.Write("Row:");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Col:");
            int col = int.Parse(Console.ReadLine());

            Console.WriteLine(mt[row, col]);
        }

        static void AddValue(Matrix mt)
        {
            Console.Write("Row:");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Col:");
            int col = int.Parse(Console.ReadLine());
            Console.Write("Value:");
            int value = int.Parse(Console.ReadLine());

            mt.Add(row, col, value);
        }

        static void MultiplyingMatrix(Matrix mt)
        {
            int[,] matrix = CreateMatrix();
            FillMatrix(matrix);
            mt.MultiplyingMatrices(matrix);
        }

        static void SubstractMatrix(Matrix mt)
        {
            Console.Write("Start row:");
            int startRow = int.Parse(Console.ReadLine());
            Console.Write("Start col:");
            int startCol = int.Parse(Console.ReadLine());
            Console.Write("End row:");
            int endRow = int.Parse(Console.ReadLine());
            Console.Write("End col:");
            int endCol = int.Parse(Console.ReadLine());

            Matrix substracted = new Matrix(mt.Substract(startRow, startCol, endRow, endCol));
            Console.WriteLine("Substracted matrix:");
            PrintMatrix(substracted);
        }

        static void PrintMatrix(Matrix mt)
        {
            Console.WriteLine(mt.ToString());
        }
    }
}
