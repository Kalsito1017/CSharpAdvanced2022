using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Truffle_Hunter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            
            char[,] forest = new char[size, size];
            FillMatrix(forest);
            string command = Console.ReadLine();
            Dictionary<char, int> trufflesOfPeter = new Dictionary<char, int>
            {
                {'B', 0},
                {'S', 0},
                {'W', 0}
            };
            int boarTruffles = 0;
            while (command != "Stop the hunt")
            {
                string[] parts = command.Split(' ');
                string commandName = parts[0];
                int row = int.Parse(parts[1]);
                int col = int.Parse(parts[2]);
                if (commandName == "Collect")
                {
                    if (CheckIsTruffle(forest, row, col))
                    {
                        trufflesOfPeter[forest[row, col]]++;
                        forest[row, col] = '-';
                    }
                }
                else if (commandName == "Wild_Boar")
                {
                    string direction = parts[3];
                    switch (direction)
                    {
                        case "up":
                            for (int rows = row; row >= 0; row -= 2)
                            {
                                boarTruffles += BoarMovement(forest, row, col);
                            }

                            break;

                        case "down":
                            for (int rows = row; row < size; row += 2)
                            {
                                boarTruffles += BoarMovement(forest, row, col);
                            }
                            break;

                        case "left":
                            for (int cols = col; col >= 0; col -= 2)
                            {
                                boarTruffles += BoarMovement(forest, row, col);
                            }
                            break;

                        case "right":
                            for (int cols = col; col < size; col += 2)
                            {
                                boarTruffles += BoarMovement(forest, row, col);
                            }
                            break;
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Peter manages to harvest {trufflesOfPeter['B']} black, {trufflesOfPeter['S']} summer, and {trufflesOfPeter['W']} white truffles.");
            Console.WriteLine($"The wild boar has eaten {boarTruffles} truffles.");
            for (int row = 0; row < forest.GetLength(0); row++)
            {
                for (int col = 0; col < forest.GetLength(1); col++)
                {
                    Console.Write(forest[row, col] + " ");
                }
                Console.WriteLine();
            }

        }
        private static int BoarMovement(char[,] forest, int row, int col)
        {
            int boarTruffles = 0;

            if (CheckIsTruffle(forest, row, col))
            {
                boarTruffles++;
                forest[row, col] = '-';
            }

            return boarTruffles;
        }
        private static void FillMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowItems = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowItems[col];
                }
            }
        }
        private static bool CheckIsTruffle(char[,] forest, int row, int col)
        {
            return forest[row, col] == 'B' || forest[row, col] == 'S' || forest[row, col] == 'W';
        }
    }
}
