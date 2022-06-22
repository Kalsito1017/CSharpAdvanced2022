namespace _7._Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            if (size < 3)
            {
                Console.WriteLine("0");
                return;
            }

            char[,] board = new char[size, size];

            FillMatrix(board);

            int minCounter = 0;

            while (GetMaxCounter(board) > 0)
            {
                minCounter++;
            }

            Console.WriteLine(minCounter);
        }

        private static int GetMaxCounter(char[,] board)
        {
            int counter = 0;
            int maxCounter = 0;
            int maxRow = 0;
            int maxCol = 0;

            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    if (board[row, col] == 'K')
                    {
                        if (IsIndexValid(board, row - 2, col - 1) && board[row - 2, col - 1] == 'K')
                        {
                            counter++;
                        }
                        if (IsIndexValid(board, row - 2, col + 1) && board[row - 2, col + 1] == 'K')
                        {
                            counter++;
                        }
                        if (IsIndexValid(board, row - 1, col - 2) && board[row - 1, col - 2] == 'K')
                        {
                            counter++;
                        }
                        if (IsIndexValid(board, row - 1, col + 2) && board[row - 1, col + 2] == 'K')
                        {
                            counter++;
                        }
                        if (IsIndexValid(board, row + 2, col - 1) && board[row + 2, col - 1] == 'K')
                        {
                            counter++;
                        }
                        if (IsIndexValid(board, row + 2, col + 1) && board[row + 2, col + 1] == 'K')
                        {
                            counter++;
                        }
                        if (IsIndexValid(board, row + 1, col - 2) && board[row + 1, col - 2] == 'K')
                        {
                            counter++;
                        }
                        if (IsIndexValid(board, row + 1, col + 2) && board[row + 1, col + 2] == 'K')
                        {
                            counter++;
                        }
                    }

                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        maxRow = row;
                        maxCol = col;
                    }

                    counter = 0;
                }
            }
            board[maxRow, maxCol] = '0';

            return maxCounter;
        }
        private static void FillMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowItems = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowItems[col];
                }
            }
        }
        private static bool IsIndexValid(char[,] matrix, int row, int col)
        {
            return row >= 0 && col >= 0 && matrix.GetLength(0) > row && matrix.GetLength(1) > col;
        }
    }
}