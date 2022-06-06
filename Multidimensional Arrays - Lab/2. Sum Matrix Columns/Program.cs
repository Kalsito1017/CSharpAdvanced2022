using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = arr[0];
            int cols = arr[1];
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowsInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < rowsInput.Length; col++)
                {
                    matrix[row, col] = rowsInput[col];
                }
            }
            
            for (cols = 0; cols < matrix.GetLength(1); cols++)
            {
                int colSum = 0;

                for (rows = 0; rows < matrix.GetLength(0); rows++)
                {
                    colSum += matrix[rows, cols];
                }
                Console.WriteLine(colSum);
            }
            
           

        }
    }
}
