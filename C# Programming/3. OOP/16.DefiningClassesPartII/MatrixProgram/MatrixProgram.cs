using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatrixProgram.Data;

namespace MatrixProgram
{
    class MatrixProgram
    {
        static void Main(string[] args)
        {
            //Create two matrices
            Matrix<int> mat1 = new Matrix<int>(3, 5);
            Matrix<int> mat2 = new Matrix<int>(3, 5);

            //Fill the matrices with numbers
            for (int i = 0; i < mat1.Rows; i++)
            {
                for (int j = 0; j < mat1.Cols; j++)
                {
                    mat1.AddNumber(i + j, i, j);
                }
            }
            for (int i = 0; i < mat1.Rows; i++)
            {
                for (int j = 0; j < mat1.Cols; j++)
                {
                    mat2[i, j] = i + j;
                }
            }

            //Print them
            Console.WriteLine(mat1.ToString());
            Console.WriteLine(mat2.ToString());

            //Use predefined operators and print the result
            Console.WriteLine((mat1 + mat2).ToString());
            Console.WriteLine((mat1 - mat2).ToString());
            //Console.WriteLine((mat2*mat2).ToString()); //For multiplication we need the row on the first matrix and col on the second matrix to be equal
            Console.WriteLine(mat1 == mat2);
        }
    }
}
