namespace _5._Snake_Moves;

internal class Program
{
    static void Main(string[] args)
    {
        int[] size = Console.ReadLine()
                   .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToArray();

        int rows = size[0];
        int cols = size[1];

        char[,] matrix = new char[rows, cols];
        char[] snakesLenght = Console.ReadLine().ToCharArray();

        Queue<char> snake = new Queue<char>(snakesLenght);

        for (int row = 0; row < rows; row++)
        {
            if (row % 2 == 0)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = snake.Peek();
                    snake.Enqueue(snake.Dequeue());
                }
            }
            else
            {
                for (int col = cols - 1; col >= 0; col--)
                {
                    matrix[row, col] = snake.Peek();
                    snake.Enqueue(snake.Dequeue());
                }
            }
        }
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col]);
            }

            Console.WriteLine();
        }
    }
}