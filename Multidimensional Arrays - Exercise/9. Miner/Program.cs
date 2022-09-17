using System;
using System.Linq;

namespace _9._Miner
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //* a regular position on the field
            // e the end of the route
            // c coal
            // s the place where the miner starts
            int sizeofmatrix = int.Parse(Console.ReadLine()!);
            string[] commands = Console.ReadLine()?.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int collectedcoals = 0;
            char[,] field = new char[sizeofmatrix, sizeofmatrix];
            FillMatrix(field);
            int coals = CountCoals(field);
            int minerRow = -1;
            int minerCol = -1;
            for (int row = 0; row < sizeofmatrix; row++)
            {
                for (int col = 0; col < sizeofmatrix; col++)
                {
                    if (field[row, col] == 's')
                    {
                        minerRow = row;
                        minerCol = col;
                        break;
                    }
                    if (field[row, col] == 'c')
                    {
                        collectedcoals++;
                    }
                }
            }
            int currRow = minerRow;
            int currCol = minerCol;


            foreach (var command in commands)
            {
                switch (command)
                {
                    case "up":
                        if (IsInside(field, currRow - 1, currCol))
                        {
                            currRow--;
                            if (field[currRow, currCol] == 'c')
                            {
                                coals--;

                                if (coals == 0)
                                {
                                    Console.WriteLine($"You collected all coals! ({currRow}, {currCol})");
                                    return;
                                }

                                field[currRow, currCol] = '*';
                            }
                            else if (field[currRow, currCol] == 'e')
                            {
                                Console.WriteLine($"Game over! ({currRow}, {currCol})");
                                return;
                            }

                        }
                        break;
                    case "down":
                        if (IsInside(field, currRow + 1, currCol))
                        {
                            currRow++;

                            if (field[currRow, currCol] == 'c')
                            {
                                coals--;

                                if (coals == 0)
                                {
                                    Console.WriteLine($"You collected all coals! ({currRow}, {currCol})");
                                    return;
                                }

                                field[currRow, currCol] = '*';
                            }
                            else if (field[currRow, currCol] == 'e')
                            {
                                Console.WriteLine($"Game over! ({currRow}, {currCol})");
                                return;
                            }
                        }
                        break;
                    case "left":
                        if (IsInside(field, currRow, currCol - 1))
                        {
                            currCol--;

                            if (field[currRow, currCol] == 'c')
                            {
                                coals--;

                                if (coals == 0)
                                {
                                    Console.WriteLine($"You collected all coals! ({currRow}, {currCol})");
                                    return;
                                }

                                field[currRow, currCol] = '*';
                            }
                            else if (field[currRow, currCol] == 'e')
                            {
                                Console.WriteLine($"Game over! ({currRow}, {currCol})");
                                return;
                            }
                        }
                        break;
                    case "right":
                        if (IsInside(field, currRow, currCol + 1))
                        {
                            currCol++;

                            if (field[currRow, currCol] == 'c')
                            {
                                coals--;

                                if (coals == 0)
                                {
                                    Console.WriteLine($"You collected all coals! ({currRow}, {currCol})");
                                    return;
                                }

                                field[currRow, currCol] = '*';
                            }
                            else if (field[currRow, currCol] == 'e')
                            {
                                Console.WriteLine($"Game over! ({currRow}, {currCol})");
                                return;
                            }
                        }
                        break;
                }
            }


            Console.WriteLine($"{coals} coals left. ({currRow}, {currCol})");
        }

        private static void FillMatrix(char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                char[] rowItems = Console.ReadLine()?.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row, col] = rowItems![col];
                }
            }
        }
        private static bool IsInside(char[,] field, int row, int col)
        {
            return row >= 0 && col >= 0 && field.GetLength(0) > row && field.GetLength(1) > col;
        }
        public static int CountCoals(char[,] matrix)
        {
            int count = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'c')
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
    
}