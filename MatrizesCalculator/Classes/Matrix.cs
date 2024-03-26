using System;

namespace MatrizesCalculator.Classes
{
    public class Matrix
    {
        private int[,] data;

        public int Rows { get; private set; }
        public int Cols { get; private set; }

        public Matrix(int rows, int cols)
        {
            Rows = rows;
            Cols = cols;
            data = new int[rows, cols];
        }

        public void Set(int row, int col, int value)
        {
            data[row, col] = value;
        }

        public int Get(int row, int col)
        {
            if (row < 0 || row >= Rows || col < 0 || col >= Cols)
            {
                throw new IndexOutOfRangeException("Índices fora dos limites da matriz");
            }

            return data[row, col];
        }
    }

    // Outras classes e métodos...
}
