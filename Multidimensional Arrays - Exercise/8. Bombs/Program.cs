
using System;
using System.Linq;
namespace _8._Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            for (int row = 0; row < size; row++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }
            int[] indexes = Console.ReadLine().Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int i = 0; i < indexes.Length; i+=2)
            {
                int row = indexes[i];
                int col = indexes[i + 1];
                if (matrix[row, col] <= 0)
                {
                    continue;
                }
                int value = matrix[row, col];

                //up, down, left, right, upright, upleft,downLeft, downRight
                //up
                if (IsInside(matrix, row - 1,col) && matrix[row - 1, col] > 0 )
                {
                    matrix[row - 1, col] -= value;
                }
                //down
                if (IsInside(matrix, row + 1, col) && matrix[row + 1, col] > 0)
                {
                    matrix[row + 1, col] -= value;
                }
                //left
                if (IsInside(matrix, row , col - 1) && matrix[row , col - 1] > 0)
                {
                    matrix[row , col - 1] -= value;
                }
                //right
                if (IsInside(matrix, row , col + 1) && matrix[row , col + 1] > 0)
                {
                    matrix[row , col + 1] -= value;
                }
                //upRight
                if (IsInside(matrix, row - 1,col + 1) && matrix[row - 1, col + 1] > 0 )
                {
                    matrix[row - 1, col + 1] -= value;
                }
                //upLeft
                if (IsInside(matrix, row - 1, col - 1) && matrix[row - 1, col - 1] > 0)
                {
                    matrix[row - 1, col - 1] -= value;
                }
                //downLeft
                if (IsInside(matrix, row + 1, col + 1) && matrix[row + 1, col + 1] > 0)
                {
                    matrix[row + 1, col + 1] -= value;
                }
                //downRight
                if (IsInside(matrix, row + 1, col - 1) && matrix[row + 1, col - 1] > 0)
                {
                    matrix[row + 1, col - 1] -= value;
                }
                matrix[row, col] = 0;

            }
            int aliveCount = 0;
            int aliveSum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        aliveCount++;
                        aliveSum += matrix[row, col];
                    }
                }
            }

            Console.WriteLine($"Alive cells: {aliveCount}");
            Console.WriteLine($"Sum: {aliveSum}");

            PrintMatrix(matrix);


        }
        private static bool IsInside(int[,] field, int row, int col)
        {
            return row >= 0 && col >= 0 && field.GetLength(0) > row && field.GetLength(1) > col;
        }
        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}