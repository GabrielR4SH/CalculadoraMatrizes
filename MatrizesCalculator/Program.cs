using System;
using MatrizesCalculator.Classes;

namespace MatrizesCalculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Calculadora de Matrizes");
            Console.WriteLine("Digite o número de linhas e colunas da primeira matriz:");
            Console.Write("Linhas: ");
            int rowsA = int.Parse(Console.ReadLine());
            Console.Write("Colunas: ");
            int colsA = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os elementos da primeira matriz:");
            Matrix a = ReadMatrix(rowsA, colsA);

            Console.WriteLine("Digite o número de linhas e colunas da segunda matriz:");
            Console.Write("Linhas: ");
            int rowsB = int.Parse(Console.ReadLine());
            Console.Write("Colunas: ");
            int colsB = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os elementos da segunda matriz:");
            Matrix b = ReadMatrix(rowsB, colsB);

            try
            {
                Matrix sum = MatrixCalculator.Add(a, b);
                Console.WriteLine("Soma das matrizes:");
                PrintMatrix(sum);

                Matrix product = MatrixCalculator.Multiply(a, b);
                Console.WriteLine("Produto das matrizes:");
                PrintMatrix(product);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }

        static Matrix ReadMatrix(int rows, int cols)
        {
            Matrix matrix = new Matrix(rows, cols);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    int value = int.Parse(Console.ReadLine());
                    matrix.Set(i, j, value);
                }
            }
            return matrix;
        }

        static void PrintMatrix(Matrix matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    Console.Write(matrix.Get(i, j) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
