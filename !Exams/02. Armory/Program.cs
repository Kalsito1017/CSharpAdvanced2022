using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace _02._Armory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            var currRow = 0;
            var currCol = 0;
            List<int>mirrorsPosition = new List<int>();

            for (int row = 0; row < size; row++)
            {
                var input = Console.ReadLine().ToCharArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row,col] = input[col];
                    if (matrix[row,col] == 'M')
                    {
                        mirrorsPosition.Add(row);
                        mirrorsPosition.Add(col);
                    }
                    if (matrix[row,col] == 'A')
                    {
                        currRow = row;
                        currCol = col;
                    }
                }
            }
            int mirr1Row = 0;
            int mirr1Col = 0;
            int mirr2Row = 0;
            int mirr2Col = 0;
            bool hasMirrors = false;
            if (mirrorsPosition.Count > 0)
            {
                hasMirrors = true;
                mirr1Row = mirrorsPosition[0];
                mirr1Col = mirrorsPosition[1];
                mirr2Row = mirrorsPosition[2];
                mirr2Col = mirrorsPosition[3];
            }

            
            
            var sum = 0;
            while (sum < 65)
            {
                matrix[currRow, currCol] = '-';
                
                var directions = Console.ReadLine();
               
                switch(directions)
                {
                    case "up": currRow--;
                        if (!IsIndexValid(matrix, currRow, currCol))
                        {
                            Console.WriteLine("I do not need more swords!");
                            Console.WriteLine($"The king paid {sum} gold coins.");
                            PrintMatrix(matrix);
                            return;
                        }
                        if (hasMirrors)
                        {
                            if (matrix[currRow, currCol] == 'M')
                            {
                                if (currRow == mirr1Row && currCol == mirr1Col)
                                {
                                    currRow = mirr2Row;
                                    currCol = mirr2Col;
                                    matrix[mirr1Row, mirr1Col] = '-';
                                }
                                else
                                {
                                    currRow = mirr1Row;
                                    currCol = mirr1Col;
                                    matrix[mirr2Row, mirr2Col] = '-';
                                }
                            }
                        }
                        if (char.IsDigit(matrix[currRow, currCol]))
                        {
                            sum += matrix[currRow, currCol] - 48; // -48?!
                        }
                        matrix[currRow, currCol] = 'A';
                        break;
                    case "down": currRow++;
                        if(!IsIndexValid(matrix, currRow, currCol))
                        {
                            Console.WriteLine("I do not need more swords!");
                            Console.WriteLine($"The king paid {sum} gold coins.");
                            PrintMatrix(matrix);
                            return;
                        }
                        if (hasMirrors)
                        {
                            if (matrix[currRow, currCol] == 'M')
                            {
                                if (currRow == mirr1Row && currCol == mirr1Col)
                                {
                                    currRow = mirr2Row;
                                    currCol = mirr2Col;
                                    matrix[mirr1Row, mirr1Col] = '-';
                                }
                                else
                                {
                                    currRow = mirr1Row;
                                    currCol = mirr1Col;
                                    matrix[mirr2Row, mirr2Col] = '-';
                                }
                            }
                        }
                        if (char.IsDigit(matrix[currRow,currCol]))
                        {
                            sum += matrix[currRow, currCol] - 48; // - 48?!
                        }
                        matrix[currRow, currCol] = 'A';
                        break;
                    case "left":
                        currCol--;
                        if (!IsIndexValid(matrix, currRow, currCol))
                        {
                            Console.WriteLine("I do not need more swords!");
                            Console.WriteLine($"The king paid {sum} gold coins.");
                            PrintMatrix(matrix);
                            return;
                        }
                        if (hasMirrors)
                        {
                            if (matrix[currRow, currCol] == 'M')
                            {
                                if (currRow == mirr1Row && currCol == mirr1Col)
                                {
                                    currRow = mirr2Row;
                                    currCol = mirr2Col;
                                    matrix[mirr1Row, mirr1Col] = '-';
                                }
                                else
                                {
                                    currRow = mirr1Row;
                                    currCol = mirr1Col;
                                    matrix[mirr2Row, mirr2Col] = '-';
                                }
                            }
                        }
                        if (char.IsDigit(matrix[currRow, currCol]))
                        {
                            sum += matrix[currRow, currCol] - 48; // - 48?!
                        }
                        matrix[currRow, currCol] = 'A';
                        break;
                    case "right":
                        currCol++;
                        if (!IsIndexValid(matrix, currRow, currCol))
                        {
                            Console.WriteLine("I do not need more swords!");
                            Console.WriteLine($"The king paid {sum} gold coins.");
                            PrintMatrix(matrix);
                            return;
                        }
                        if (hasMirrors)
                        {
                            if (matrix[currRow, currCol] == 'M')
                            {
                                if (currRow == mirr1Row && currCol == mirr1Col)
                                {
                                    currRow = mirr2Row;
                                    currCol = mirr2Col;
                                    matrix[mirr1Row, mirr1Col] = '-';
                                }
                                else
                                {
                                    currRow = mirr1Row;
                                    currCol = mirr1Col;
                                    matrix[mirr2Row, mirr2Col] = '-';
                                }
                            }
                        }
                        if (char.IsDigit(matrix[currRow, currCol]))
                        {
                            sum += matrix[currRow, currCol] - 48; // - 48?!
                        }
                        matrix[currRow, currCol] = 'A';
                        break;

                }
            }
            if (sum >= 65)
            {
                Console.WriteLine("Very nice swords, I will come back for more!");
            }

            Console.WriteLine($"The king paid {sum} gold coins.");

            PrintMatrix(matrix);

        }
        private static bool IsIndexValid(char[,] matrix, int row, int col)
        {
            return row >= 0 && col >= 0 && row < matrix.GetLength(0) && col < matrix.GetLength(1);
        }
        private static void PrintMatrix(char[,] matrix)
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
