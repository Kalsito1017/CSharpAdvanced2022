using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Beaver_at_Work
{
    public class Program
    {
        private static int beaverRow;
        private static int beaverCol;
        private static char[,] matrix;
        private static string lastDirection;

        private static List<char> branches = new List<char>();
        private static int totalBranches = 0;

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            matrix = new char[n, n];

            //Initialize Matrix and set bunny position
            for (int i = 0; i < n; i++)
            {
                char[] input = Console.ReadLine()
                    .Replace(" ", "")
                    .ToCharArray();

                for (int j = 0; j < input.Length; j++)
                {
                    matrix[i, j] = input[j];

                    if (matrix[i, j] == 'B')
                    {
                        beaverRow = i;
                        beaverCol = j;
                    }
                    else if (char.IsLower(matrix[i, j]))
                    {
                        totalBranches++;
                    }
                }
            }

            string direction = Console.ReadLine();

            while (direction != "end")
            {
                lastDirection = direction;

                if (direction == "up")
                {
                    Move(-1, 0);
                }
                else if (direction == "down")
                {
                    Move(1, 0);
                }
                else if (direction == "right")
                {
                    Move(0, 1);
                }
                else if (direction == "left")
                {
                    Move(0, -1);
                }

                if (totalBranches == 0)
                {
                    break;
                }
                direction = Console.ReadLine();
            }

            if (totalBranches > 0)
            {
                Console.WriteLine($"The Beaver failed to collect every wood branch. There are {totalBranches} branches left.");
            }
            else
            {
                Console.WriteLine($"The Beaver successfully collect {branches.Count} wood branches: {string.Join(", ", branches)}.");
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write((char)matrix[i, j]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        private static void Move(int row, int col)
        {
            if (!IsInside(beaverRow + row, beaverCol + col))
            {
                if (branches.Any())
                {
                    branches.Remove(branches[branches.Count - 1]);
                }
                return;
            }
            matrix[beaverRow, beaverCol] = '-';
            beaverRow += row;
            beaverCol += col;

            if (char.IsLower(matrix[beaverRow, beaverCol]))
            {
                branches.Add(matrix[beaverRow, beaverCol]);
                matrix[beaverRow, beaverCol] = 'B';
                totalBranches--;
            }
            else if (matrix[beaverRow, beaverCol] == 'F')
            {
                matrix[beaverRow, beaverCol] = '-';

                if (lastDirection == "up")
                {
                    if (beaverRow == 0)
                    {
                        if (char.IsLower(matrix[matrix.GetLength(0) - 1, beaverCol]))
                        {
                            branches.Add(matrix[matrix.GetLength(0) - 1, beaverCol]);
                            totalBranches--;
                        }
                        beaverRow = matrix.GetLength(0) - 1;
                        matrix[beaverRow, beaverCol] = 'B';
                    }
                    else
                    {
                        if (char.IsLower(matrix[0, beaverCol]))
                        {
                            branches.Add(matrix[0, beaverCol]);
                            totalBranches--;
                        }
                        beaverRow = 0;
                        matrix[beaverRow, beaverCol] = 'B';
                    }
                }
                else if (lastDirection == "down")
                {
                    if (beaverRow == matrix.GetLength(0) - 1)
                    {
                        if (char.IsLower(matrix[0, beaverCol]))
                        {
                            branches.Add(matrix[0, beaverCol]);
                            totalBranches--;
                        }
                        beaverRow = 0;
                        matrix[beaverRow, beaverCol] = 'B';
                    }
                    else
                    {
                        if (char.IsLower(matrix[matrix.GetLength(0) - 1, beaverCol]))
                        {
                            branches.Add(matrix[matrix.GetLength(0) - 1, beaverCol]);
                            totalBranches--;
                        }
                        beaverRow = matrix.GetLength(0) - 1;
                        matrix[beaverRow, beaverCol] = 'B';
                    }
                }
                else if (lastDirection == "right")
                {
                    if (beaverCol == matrix.GetLength(1) - 1)
                    {
                        if (char.IsLower(matrix[beaverRow, 0]))
                        {
                            branches.Add(matrix[beaverRow, 0]);
                            totalBranches--;
                        }
                        beaverCol = 0;
                        matrix[beaverRow, beaverCol] = 'B';
                    }
                    else
                    {
                        if (char.IsLower(matrix[beaverRow, matrix.GetLength(1) - 1]))
                        {
                            branches.Add(matrix[beaverRow, matrix.GetLength(1) - 1]);
                            totalBranches--;
                        }
                        beaverCol = matrix.GetLength(1) - 1;
                        matrix[beaverRow, beaverCol] = 'B';
                    }
                }
                else if (lastDirection == "left")
                {
                    if (beaverCol == 0)
                    {
                        if (char.IsLower(matrix[beaverRow, matrix.GetLength(1) - 1]))
                        {
                            branches.Add(matrix[beaverRow, matrix.GetLength(1) - 1]);
                            totalBranches--;
                        }
                        beaverCol = matrix.GetLength(1) - 1;
                        matrix[beaverRow, beaverCol] = 'B';
                    }
                    else
                    {
                        if (char.IsLower(matrix[beaverRow, 0]))
                        {
                            branches.Add(matrix[beaverRow, 0]);
                            totalBranches--;
                        }
                        beaverCol = 0;
                        matrix[beaverRow, beaverCol] = 'B';
                    }
                }
            }
            else
            {
                matrix[beaverRow, beaverCol] = 'B';
            }
        }

        private static bool IsInside(int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) &&
                   col >= 0 && col < matrix.GetLength(1);
        }
    }
}

