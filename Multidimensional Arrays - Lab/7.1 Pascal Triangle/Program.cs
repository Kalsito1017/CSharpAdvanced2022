using System;

namespace _7._1_Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            long[][] pascalTriangle = new long[number][];
            pascalTriangle[0] = new long[1] { 1 };
            for (long row = 1; row < number; row++)
            {
                pascalTriangle[row] = new long[pascalTriangle[row - 1].Length + 1];
                for (long col = 0; col < pascalTriangle[row].Length; col++)
                {
                    if (pascalTriangle[row - 1].Length > col)
                    {
                        pascalTriangle[row][col] += pascalTriangle[row - 1][col];
                    }
                    if (col > 0)
                    {
                        pascalTriangle[row][col] += pascalTriangle[row - 1][col - 1];
                    }
                }
            }
            PrintJaggedArray(pascalTriangle);
        }
        
        public static void PrintJaggedArray(long[][] jagged)
        {
            for (long row = 0; row < jagged.Length; row++)
            {
                Console.WriteLine($"{string.Join(" ", jagged[row])}");
            }
        }
    }
}
