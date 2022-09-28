using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Garden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimension[0];
            int columns = dimension[1];
            int[,] garden = new int[rows, columns];
            for (int rowz = 0; rowz < garden.GetLength(0); rowz++)
            {
                for (int colz = 0; colz < garden.GetLength(1); colz++)
                {
                    garden[rowz, colz] = 0;
                }
            }
            List<int> flowers = new List<int>();
            string cmd;
            while ((cmd = Console.ReadLine()) != "Bloom Bloom Plow")
            {
                int[] coordinates = cmd.Split().Select(int.Parse).ToArray();
                int row = coordinates[0];
                int col = coordinates[1];
                if (!IsInRange(garden, row, col))
                {
                    Console.WriteLine("Invalid coordinates.");
                    continue;
                }
                
                garden[row, col]++;
                flowers.Add(row);
                flowers.Add(col);


            }
            for (int coordinates = 0; coordinates < flowers.Count; coordinates += 2)
            {
                int currRow = flowers[coordinates];
                int currCol = flowers [coordinates + 1];

                for (int row = 0; row < garden.GetLength(0); row++)
                {
                    garden[row, currCol]++;
                }

                for (int col = 0; col < garden.GetLength(1); col++)
                {
                    garden[currRow, col]++;
                }

                garden[currRow, currCol] -= 2;
            }

            PrintGarden(garden);
        }
        private static bool IsInRange(int[,] garden, int row, int col)
        {
            return row >= 0 && col >= 0 && row < garden.GetLength(0) && col < garden.GetLength(1);
        }
        private static void PrintGarden(int[,] garden)
        {
            for (int row = 0; row < garden.GetLength(0); row++)
            {
                for (int col = 0; col < garden.GetLength(1); col++)
                {
                    Console.Write(garden[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
