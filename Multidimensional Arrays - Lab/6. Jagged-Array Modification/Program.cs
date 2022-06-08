using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nxn = int.Parse(Console.ReadLine());
            int[][] jagged = ReadJaggedArray(nxn);
            string command = Console.ReadLine();
            while (command != "END")
            {
                
                string[] vs = command.Split(' ',StringSplitOptions.RemoveEmptyEntries);
                string comand = vs[0];
                int row = int.Parse(vs[1]);
                int col = int.Parse(vs[2]);
                int value = int.Parse(vs[3]);

                if (row < 0 || col < 0 || row >= jagged.Length || col >= jagged[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else if (comand == "Add")
                {
                    jagged[row][col] += value;
                }
                else if (comand == "Subtract")
                {
                    jagged[row][col] -= value;
                }
                command = Console.ReadLine();

            }
            PrintJaggedArray(jagged);

        }
        public static int[][] ReadJaggedArray(int rows)
        {
            int[][] jagged = new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                jagged[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            return jagged;
        }
        public static void PrintJaggedArray(int[][] jagged)
        {
            foreach (var t in jagged)
                Console.WriteLine(string.Join(" ", t));
        }
    }
}
