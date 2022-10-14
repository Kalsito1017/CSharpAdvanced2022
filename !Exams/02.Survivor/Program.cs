using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Survivor
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int rows = int.Parse(Console.ReadLine());
            var beach = new char[rows][];
            for (int row = 0; row < beach.GetLength(0); row++)
            {
                char[] inputRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                beach[row] = inputRow;
            }
            int tokens = 0;
            int opponenttokens = 0;
            string command = Console.ReadLine();
            while (command != "Gong")
            {
                string[] currArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string comand = currArgs[0];
                int row = int.Parse(currArgs[1]);
                int col = int.Parse(currArgs[2]);
                if (comand == "Find")
                {
                    if (IsIndexValid(beach, row, col))
                    {
                        CheckForTokens(beach, row, col, ref tokens);
                    }
                }
                else if (comand == "Opponent")
                {
                    string direction = currArgs[3];
                    if (IsIndexValid(beach, row, col))
                    {
                        CheckForTokens(beach, row, col, ref opponenttokens);
                    }
                    else
                    {
                        continue;
                    }
                    for (int steps = 0; steps < 3; steps++)
                    {
                        switch(direction)
                        {
                            case "up":
                                row--;
                                break;
                            case "down":
                                row++;
                                break;
                            case "left":
                                col--;
                                break;
                            case "right":
                                col++;
                                break;
                        }
                        if (IsIndexValid(beach, row, col))
                        {
                            CheckForTokens(beach, row, col, ref opponenttokens);
                        }
                        else
                        {
                            break;
                        }
                    }
                    
                }
                
            }

            PrintBeach(beach);
            Console.WriteLine($"Collected tokens: {tokens}");
            Console.WriteLine($"Opponent's tokens: {opponenttokens}");

        }
        private static bool IsIndexValid(char[][] beach, int row, int col)
        {
            return row >= 0 && col >= 0 && row < beach.GetLength(0) && col < beach[row].Length;
        }
        private static void CheckForTokens(char[][] beach, int row, int col, ref int tokens)
        {
            if (beach[row][col] == 'T')
            {
                tokens++;
                beach[row][col] = '-';
            }
        }
        private static void PrintBeach(char[][] beach)
        {
            for (int row = 0; row < beach.GetLength(0); row++)
            {
                Console.WriteLine(String.Join(" ", beach[row]));
            }
        }
    }
}
