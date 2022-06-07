using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int biggestSquareRows = 2;
            int biggestSquareCols = 2;
            int[] arr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = arr[0];
            int cols = arr[1];
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowsInput = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < rowsInput.Length; col++)
                {
                    matrix[row, col] = rowsInput[col];
                }
            }
            int maxSum = int.MinValue;
            int maxRowIndex = 0;
            int maxColIndex = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (row + biggestSquareRows - 1 < rows && col + biggestSquareCols - 1 < cols)
                    {
                        int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                        if (sum > maxSum)
                        {
                            maxSum = sum;
                            maxColIndex = col;
                            maxRowIndex = row;
                        }

                    }
                }
            }
            for (int row = maxRowIndex; row < maxRowIndex + biggestSquareRows; row++)

            {
                for (int col = maxColIndex; col < maxColIndex + biggestSquareCols; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSum);
        }
    }
}
