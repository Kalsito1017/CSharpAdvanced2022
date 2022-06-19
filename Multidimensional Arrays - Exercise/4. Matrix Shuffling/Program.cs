using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                   .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToArray();

            int rows = size[0];
            int cols = size[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowItems = Console.ReadLine()
                    .Split(" ");

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowItems[col];
                }
            }

            string cmd;
            while ((cmd = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = cmd.Split(' ');

                if (!IsCommandValid(cmdArgs, matrix))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                int row1 = int.Parse(cmdArgs[1]);
                int col1 = int.Parse(cmdArgs[2]);
                int row2 = int.Parse(cmdArgs[3]);
                int col2 = int.Parse(cmdArgs[4]);

                string firstElement = matrix[row1, col1];
                string secondElement = matrix[row2, col2];

                matrix[row1, col1] = secondElement;
                matrix[row2, col2] = firstElement;

                PrintMatrix(matrix);
            }
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }

                Console.WriteLine();
            }
        }

        private static bool IsCommandValid(string[] cmdArgs, string[,] matrix)
        {
            if (cmdArgs[0] != "swap")
            {
                return false;
            }

            if (cmdArgs.Length != 5)
            {
                return false;
            }

            if (int.Parse(cmdArgs[1]) < 0 || int.Parse(cmdArgs[1]) >= matrix.GetLength(0)
                || int.Parse(cmdArgs[2]) < 0 || int.Parse(cmdArgs[2]) >= matrix.GetLength(1)
                || int.Parse(cmdArgs[3]) < 0 || int.Parse(cmdArgs[3]) >= matrix.GetLength(0)
                || int.Parse(cmdArgs[4]) < 0 || int.Parse(cmdArgs[4]) >= matrix.GetLength(1))
            {
                return false;
            }

            return true;
        }
    }
}

