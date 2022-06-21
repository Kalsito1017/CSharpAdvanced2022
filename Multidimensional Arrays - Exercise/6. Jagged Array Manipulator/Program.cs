namespace _6._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] jaggedMatrix = new double[rows][];

            FillJaggedMatrix(jaggedMatrix);

            for (int row = 0; row < rows - 1; row++)
            {
                if (jaggedMatrix[row].Length == jaggedMatrix[row + 1].Length)
                {
                    jaggedMatrix[row] = jaggedMatrix[row].Select(num => num * 2).ToArray();
                    jaggedMatrix[row + 1] = jaggedMatrix[row + 1].Select(num => num * 2).ToArray();
                }
                else
                {
                    jaggedMatrix[row] = jaggedMatrix[row].Select(num => num / 2).ToArray();
                    jaggedMatrix[row + 1] = jaggedMatrix[row + 1].Select(num => num / 2).ToArray();
                }
            }

            string cmd;
            while ((cmd = Console.ReadLine()) != "End")
            {
                string cmdType = cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries)[0];
                int row = int.Parse(cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries)[1]);
                int col = int.Parse(cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries)[2]);
                int value = int.Parse(cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries)[3]);

                switch (cmdType)
                {
                    case "Add":
                        if (IsIndexValid(jaggedMatrix, row, col))
                        {
                            jaggedMatrix[row][col] += value;
                        }
                        break;
                    case "Subtract":
                        if (IsIndexValid(jaggedMatrix, row, col))
                        {
                            jaggedMatrix[row][col] -= value;
                        }
                        break;
                }
            }

            PrintJaggedMatrix(jaggedMatrix);
        }

        private static void PrintJaggedMatrix(double[][] jaggedMatrix)
        {
            foreach (double[] row in jaggedMatrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }

        private static bool IsIndexValid(double[][] jaggedMatrix, int row, int col)
        {
            return row >= 0 && col >= 0 && jaggedMatrix.GetLength(0) > row && jaggedMatrix[row].Length > col;
        }

        private static void FillJaggedMatrix(double[][] jaggedMatrix)
        {
            for (int row = 0; row < jaggedMatrix.Length; row++)
            {
                jaggedMatrix[row] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse)
                    .ToArray();
            }
        }


    }
}