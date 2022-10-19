using System;

namespace _02._Re_Volt
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int n = int.Parse(Console.ReadLine());
            int numberofcommands = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int rowf = 0;
            int colf = 0;
            for (int row = 0; row < n; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row,col] = input[col];
                    if (matrix[row,col] == 'f')
                    {
                        rowf = row;
                        colf = col;
                    }
                }
            }
            bool hasWIn = false;
            for (int i = 0; i < numberofcommands; i++)
            {
                string commands = Console.ReadLine();
                matrix[rowf, colf] = '-';
                
                switch (commands)
                {
                    case "up": rowf--;
                        Teleport(IsInside(matrix, rowf, colf), ref rowf, ref colf, matrix);
                        if (matrix[rowf, colf] == 'F')
                        {
                            matrix[rowf, colf] = 'f';
                            hasWIn = true;
                            break;
                        }
                        
                        else if (matrix[rowf,colf] == 'B')
                        {
                            rowf--;
                            Teleport(IsInside(matrix, rowf, colf), ref rowf, ref colf, matrix);
                            if (matrix[rowf, colf] == 'F')
                            {
                                matrix[rowf, colf] = 'f';
                                hasWIn = true;
                                break;
                            }
                            matrix[rowf, colf] = 'f';

                        }
                        else if (matrix[rowf,colf] == 'T')
                        {
                            rowf++;
                            matrix[rowf, colf] = 'f';
                        }
                        else
                        {
                            matrix[rowf, colf] = 'f';
                        }
                        break;
                    case "down":
                        rowf++;
                        Teleport(IsInside(matrix, rowf, colf), ref rowf, ref colf, matrix);
                        if (matrix[rowf, colf] == 'F')
                        {
                            matrix[rowf, colf] = 'f';
                            hasWIn = true;
                            break;
                        }

                        else if (matrix[rowf, colf] == 'B')
                        {
                            rowf++;
                            Teleport(IsInside(matrix, rowf, colf), ref rowf, ref colf, matrix);
                            if (matrix[rowf, colf] == 'F')
                            {
                                matrix[rowf, colf] = 'f';
                                hasWIn = true;
                                break;
                            }
                            matrix[rowf, colf] = 'f';

                        }
                        else if (matrix[rowf, colf] == 'T')
                        {
                            rowf++;
                            matrix[rowf, colf] = 'f';
                        }
                        else
                        {
                            matrix[rowf, colf] = 'f';
                        }
                        break;
                    case "right":
                        rowf++;
                        Teleport(IsInside(matrix, rowf, colf), ref rowf, ref colf, matrix);
                        if (matrix[rowf, colf] == 'F')
                        {
                            matrix[rowf, colf] = 'f';
                            hasWIn = true;
                            break;
                        }

                        else if (matrix[rowf, colf] == 'B')
                        {
                            colf++;
                            Teleport(IsInside(matrix, rowf, colf), ref rowf, ref colf, matrix);
                            if (matrix[rowf, colf] == 'F')
                            {
                                matrix[rowf, colf] = 'f';
                                hasWIn = true;
                                break;
                            }
                            matrix[rowf, colf] = 'f';

                        }
                        else if (matrix[rowf, colf] == 'T')
                        {
                            rowf++;
                            matrix[rowf, colf] = 'f';
                        }
                        else
                        {
                            matrix[rowf, colf] = 'f';
                        }
                        break;
                    case "left":
                        colf--;
                        Teleport(IsInside(matrix, rowf, colf), ref rowf, ref colf, matrix);
                        if (matrix[rowf, colf] == 'F')
                        {
                            matrix[rowf, colf] = 'f';
                            hasWIn = true;
                            break;
                        }

                        else if (matrix[rowf, colf] == 'B')
                        {
                            colf--;
                            Teleport(IsInside(matrix, rowf, colf), ref rowf, ref colf, matrix);
                            if (matrix[rowf, colf] == 'F')
                            {
                                matrix[rowf, colf] = 'f';
                                hasWIn = true;
                                break;
                            }
                            matrix[rowf, colf] = 'f';
                        }
                        else if (matrix[rowf, colf] == 'T')
                        {
                            rowf++;
                            matrix[rowf, colf] = 'f';
                        }
                        else
                        {
                            matrix[rowf, colf] = 'f';
                        }
                        break;
                }
                if (hasWIn)
                {
                    break;
                }
            }
            Console.WriteLine(hasWIn ? "Player won!" : "Player lost!");
            PrintField(matrix);
        }
        private static void Teleport(bool b , ref int rowP, ref int colP, char[,] matrix)
        {
            if (!b)
            {
                if (rowP< 0)
                {
                    rowP = matrix.GetLength(0) - 1;
                }
                else if (colP < 0)
                {
                    colP = matrix.GetLength(1) - 1;
                }
                else if (rowP == matrix.GetLength(0))
                {
                    rowP = 0;
                }
                else if (colP == matrix.GetLength(1))
                {
                    colP = 0;
                }
            }
        }
        private static bool IsInside(char[,] matrix,int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) &&
                   col >= 0 && col < matrix.GetLength(1);
        }
        private static void PrintField(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
