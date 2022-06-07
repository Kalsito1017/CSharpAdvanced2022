using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            //3
            //ABC
            //DEF
            //X!@
            //!

            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            bool check = false;
            bool specialCheck = false;
            List<char> rowsInput = new List<char>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                foreach (char symbols in input)
                {
                    rowsInput.Add(symbols);
                }
                for (int j = 0; j < input.Length; j++)
                {
                    matrix[i, j] = input[j];
                }
                rowsInput.Clear();
            }
            char symbol = char.Parse(Console.ReadLine() ?? string.Empty);
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    if (specialCheck == true)
                    {
                        break;

                    }
                    else if (symbol == matrix[rows, cols])
                    {
                        Console.WriteLine($"({rows}, {cols})");
                        check = true;
                        specialCheck = true;
                        break;
                    }
                }
            }
            if (!check)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }

        }
    }
}
