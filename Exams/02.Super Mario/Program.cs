using System;
using System.Linq;

namespace _02.Super_Mario
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            int lives = int.Parse(Console.ReadLine());

            int rows = int.Parse(Console.ReadLine());

            char[][] field = new char[rows][];

            DrawTheField(field);

            int rowM = 0;
            int colM = 0;
            int rowP = 0;
            int colP = 0;

            GetTheStartPositions(field, ref rowM, ref colM, ref rowP, ref colP);

            while (rowM != rowP || colM != colP)
            {
                string[] cmdArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                char direction = char.Parse(cmdArgs[0]);
                int rowB = int.Parse(cmdArgs[1]);
                int colB = int.Parse(cmdArgs[2]);

                field[rowB][colB] = 'B';

                lives--;

                int moveRow = 0;
                int moveCol = 0;

                bool isEnd = false;

                switch (direction)
                {
                    case 'W':
                        moveRow--;
                        if (IsIndexValid(field, rowM + moveRow, colM + moveCol))
                        {
                            rowM += moveRow;
                            colM += moveCol;
                        }

                        Movement(field, ref rowM, ref colM, ref lives, ref moveRow, ref moveCol, ref isEnd);
                        if (isEnd) return;

                        break;

                    case 'S':
                        moveRow++;

                        if (IsIndexValid(field, rowM + moveRow, colM + moveCol))
                        {
                            rowM += moveRow;
                            colM += moveCol;
                        }

                        Movement(field, ref rowM, ref colM, ref lives, ref moveRow, ref moveCol, ref isEnd);
                        if (isEnd) return;
                        break;

                    case 'A':
                        moveCol--;

                        if (IsIndexValid(field, rowM + moveRow, colM + moveCol))
                        {
                            rowM += moveRow;
                            colM += moveCol;
                        }

                        Movement(field, ref rowM, ref colM, ref lives, ref moveRow, ref moveCol, ref isEnd);
                        if (isEnd) return;
                        break;

                    case 'D':
                        moveCol++;
                        if (IsIndexValid(field, rowM + moveRow, colM + moveCol))
                        {
                            rowM += moveRow;
                            colM += moveCol;
                        }

                        Movement(field, ref rowM, ref colM, ref lives, ref moveRow, ref moveCol, ref isEnd);
                        if (isEnd) return;
                        break;
                }
            }
        }

        private static void DrawTheField(char[][] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                field[row] = input;
            }
        }
        private static void GetTheStartPositions(char[][] field, ref int rowM, ref int colM, ref int rowP, ref int colP)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field[row].Length; col++)
                {
                    if (field[row][col] == 'M')
                    {
                        rowM = row;
                        colM = col;
                    }

                    if (field[row][col] == 'P')
                    {
                        rowP = row;
                        colP = col;
                    }
                }
            }
        }
        private static bool IsIndexValid(char[][] field, int row, int col)
        {
            return row >= 0 && col >= 0 && row < field.GetLength(0) && col < field[row].Length;
        }
        private static void Movement(char[][] field, ref int row, ref int col, ref int lives, ref int moveRow, ref int moveCol, ref bool isEnd)
        {
            if (field[row][col] == 'B')
            {
                lives -= 2;
                field[row - moveRow][col - moveCol] = '-';

                if (lives <= 0)
                {
                    field[row][col] = 'X';
                    Console.WriteLine($"Mario died at {row};{col}.");
                    PrintField(field);
                    isEnd = true;
                }
                else
                {
                    field[row][col] = 'M';
                }
            }
            else if (field[row][col] == 'P')
            {
                field[row][col] = '-';
                field[row - moveRow][col - moveCol] = '-';
                Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lives}");
                PrintField(field);
                isEnd = true;
            }
            else
            {
                field[row][col] = 'M';
                field[row - moveRow][col - moveCol] = '-';

                if (lives <= 0)
                {
                    field[row][col] = 'X';
                    field[row - moveRow][col - moveCol] = '-';
                    Console.WriteLine($"Mario died at {row};{col}.");
                    PrintField(field);
                    isEnd = true;
                }
            }
        }
        private static void PrintField(char[][] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                Console.WriteLine(string.Join("", field[row]));
            }
        }

    }
}

