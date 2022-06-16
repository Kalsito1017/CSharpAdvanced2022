using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nxn = int.Parse(Console.ReadLine());
            long[][] matrix = new long[nxn][];
            long leftDiagonalSum = 0;
            long rightDiagonalSum = 0;
            for (int i = 0; i < nxn; i++)
            {
                matrix[i] = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(long.Parse)
                                    .ToArray();
                leftDiagonalSum += matrix[i][i];
                rightDiagonalSum += matrix[i][matrix[i].Length - 1 - i];
            }
            Console.WriteLine(Math.Abs(leftDiagonalSum - rightDiagonalSum));

            
        }
    }
}
