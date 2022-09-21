using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Wall_Destroyer
{
    internal class Program
    {
        private static int vankoRow;
        private static int vankoCol;
        private static char[,] wall;

        private static int countOfHoles = 1;
        private static int countOfRods;

        private static bool isAlive = true;
        static void Main(string[] args)
        {
            //create the wall
            int n = int.Parse(Console.ReadLine());
            wall = new char[n, n];
            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    wall[row, col] = input[col];
                }
            }

            //find Vanko's position
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (wall[row, col] == 'V')
                    {
                        vankoRow = row;
                        vankoCol = col;
                        break;
                    }
                }
            }

            //start receiving directions
            string command = Console.ReadLine();
            while (command != "End")
            {
                if (command == "up")
                {
                    Move(-1, 0);
                }
                else if (command == "down")
                {
                    Move(1, 0);
                }
                else if (command == "left")
                {
                    Move(0, -1);
                }
                else if (command == "right")
                {
                    Move(0, 1);
                }

                if (!isAlive)
                {
                    break;
                }
                command = Console.ReadLine();
            }

            //print the matrix
            if (isAlive)
            {
                Console.WriteLine($"Vanko managed to make {countOfHoles} hole(s) and he hit only {countOfRods} rod(s).");
            }
            PrintMatrix(n);
        }

        private static void Move(int row, int col)
        {
            if (isInside(vankoRow + row, vankoCol + col))
            {
                if (wall[vankoRow + row, vankoCol + col] == 'C')
                {
                    wall[vankoRow, vankoCol] = '*';
                    vankoRow += row;
                    vankoCol += col;
                    countOfHoles++;
                    wall[vankoRow, vankoCol] = 'E';
                    Console.WriteLine($"Vanko got electrocuted, but he managed to make {countOfHoles} hole(s).");
                    isAlive = false;
                }
                else if (wall[vankoRow + row, vankoCol + col] == 'R')
                {
                    countOfRods++;
                    Console.WriteLine($"Vanko hit a rod!");
                }
                else if (wall[vankoRow + row, vankoCol + col] == '-')
                {
                    wall[vankoRow, vankoCol] = '*';
                    vankoRow += row;
                    vankoCol += col;
                    wall[vankoRow, vankoCol] = 'V';
                    countOfHoles++;
                }
                else if (wall[vankoRow + row, vankoCol + col] == '*')
                {
                    wall[vankoRow, vankoCol] = '*';
                    Console.WriteLine($"The wall is already destroyed at position [{vankoRow + row}, {vankoCol + col}]!");
                    vankoRow += row;
                    vankoCol += col;
                    wall[vankoRow, vankoCol] = 'V';
                }
            }
        }

        private static bool isInside(int row, int col)
        {
            return row >= 0 && row < wall.GetLength(0) && col >= 0 && col < wall.GetLength(1);
        }

        private static void PrintMatrix(int n)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(wall[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
