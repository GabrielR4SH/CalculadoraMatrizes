using MatrizesCalculator.Classes;
using System;

namespace MatrizesCalculator.Classes
{
    public class MatrixCalculator
    {
        public static Matrix Add(Matrix a, Matrix b)
        {
            if (a.Rows != b.Rows || a.Cols != b.Cols)
            {
                throw new ArgumentException("Matrices must have same dimensions");
            }

            Matrix result = new Matrix(a.Rows, a.Cols);

            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Cols; j++)
                {
                    result.Set(i, j, a.Get(i, j) + b.Get(i, j));
                }
            }
            return result;
        }

        public static Matrix Multiply(Matrix a, Matrix b)
        {
            if (a.Cols != b.Rows)
            {
                throw new ArgumentException("Number of columns in first matrix must equal number of rows in second matrix");
            }

            Matrix result = new Matrix(a.Rows, b.Cols);

            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < b.Cols; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < a.Cols; k++)
                    {
                        sum += a.Get(i, k) * b.Get(k, j);
                    }
                    result.Set(i, j, sum);
                }
            }

            return result;
        }
    }
}
