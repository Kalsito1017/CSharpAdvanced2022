using System;
using System.Linq;

namespace _3.Multidimensional_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int nxn = int.Parse(Console.ReadLine());
            int[,] matrix = new int[nxn, nxn];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] rowsInput = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = rowsInput[cols];
                }
            }

            int diagonalPosition = 0;
            int diagonalSum = 0;
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    diagonalSum += matrix[diagonalPosition, cols];
                    diagonalPosition++;
                }

                Console.WriteLine(diagonalSum);
                break;
            }
        }
    }
}

