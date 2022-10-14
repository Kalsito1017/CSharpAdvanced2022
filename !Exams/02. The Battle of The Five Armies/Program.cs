using System;

namespace _02._The_Battle_of_The_Five_Armies
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            int armor = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());
            char[][] matrix = new char[size][];
            int rowA = 0;
            int colA = 0;
            int rowM = 0;
            int colM = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                matrix[row] = input;
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == 'A')
                    {
                        rowA = row;
                        colA = col;
                    }
                    if (matrix[row][col] == 'M')
                    {
                        rowM = row;//smi ?
                        colM = col;
                    }
                }
            }
            while (rowA != rowM || colA != colM)
            {
                string[] cmdArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string direction = cmdArgs[0];
                int row0 = int.Parse(cmdArgs[1]);
                int col0 = int.Parse(cmdArgs[2]);
                matrix[row0][col0] = 'O';
                armor--;
                int moveRow = 0;
                int moveCol = 0;
                bool isEnd = false;
                switch (direction)
                {
                    case "up":
                        moveRow--;
                        if (IsIndexValid(matrix, rowA + moveRow, colA + moveCol))
                        {
                            rowA += moveRow;
                            colA += moveCol;
                        }
                        Movement(matrix, ref rowA, ref colA, ref armor, ref moveRow, ref moveCol, ref isEnd);
                        break;
                    case "down":
                        moveRow++;//nekude imam null :)
                        if (IsIndexValid(matrix, rowA + moveRow, colA + moveCol))
                        {
                            rowA += moveRow;
                            colA += moveCol;
                        }
                        Movement(matrix, ref rowA, ref colA, ref armor, ref moveRow, ref moveCol, ref isEnd);
                        break;
                    case "left":
                        moveCol--;
                        if (IsIndexValid(matrix, rowA + moveRow, colA + moveCol))
                        {
                            rowA += moveRow;
                            colA += moveCol;
                        }
                        Movement(matrix, ref rowA, ref colA, ref armor, ref moveRow, ref moveCol, ref isEnd);
                        break;
                    case "right":
                        moveCol++;
                        if (IsIndexValid(matrix, rowA + moveRow, colA + moveCol))
                        {
                            rowA += moveRow;
                            colA += moveCol;
                        }
                        Movement(matrix, ref rowA, ref colA, ref armor, ref moveRow, ref moveCol, ref isEnd);
                        break;
                }
            }
        }
        private static void Movement(char[][] field, ref int row, ref int col, ref int armour, ref int moveRow, ref int moveCol, ref bool isEnd)
        {
            if (field[row][col] == 'O')
            {
                armour -= 2;
                field[row - moveRow][col - moveCol] = '-';

                if (armour <= 0)
                {
                    field[row][col] = 'X';
                    Console.WriteLine($"The army was defeated at {row};{col}.");
                    PrintField(field);
                    isEnd = true;
                }
                else
                {
                    field[row][col] = 'A';
                }
            }
            else if (field[row][col] == 'M')
            {
                field[row][col] = '-';
                field[row - moveRow][col - moveCol] = '-';
                Console.WriteLine($"The army managed to free the Middle World! Armor left: {armour}");
                PrintField(field);
                isEnd = true;
            }
            else
            {
                field[row][col] = 'A';
                field[row - moveRow][col - moveCol] = '-';

                if (armour <= 0)
                {
                    field[row][col] = 'X';
                    field[row - moveRow][col - moveCol] = '-';
                    Console.WriteLine($"The army was defeated at {row};{col}.");
                    PrintField(field);
                    isEnd = true;
                }
            }
        }
        private static bool IsIndexValid(char[][] matrix, int row, int col)
        {
            return row >= 0 && col >= 0 && row < matrix.GetLength(0) && col < matrix[row].Length;
        }
        public static void PrintField(char[][] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.WriteLine(string.Join("", matrix[row]));
            }
        }
    }
}
