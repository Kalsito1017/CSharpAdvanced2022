using System;
using System.Linq;

namespace _7._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var pascalTriangle = new long[number][];
            for (var row = 0; row < number; row++)
            {
                pascalTriangle[row] = new long[row + 1];
                pascalTriangle[row][0] = 1;  // first element is 1
                pascalTriangle[row][^1] = 1; // last element is 1

                for (var col = 1; col < row; col++)
                {
                    pascalTriangle[row][col] = pascalTriangle[row - 1][col - 1] + pascalTriangle[row - 1][col];
                }
            }

            for (var row = 0; row < number; row++)
            {
                Console.WriteLine(string.Join(" ", pascalTriangle[row]));
            }

        }
    }
}
