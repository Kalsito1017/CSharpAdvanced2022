using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Scheduling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tasks = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] threads = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int valueofthetask = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>(tasks);
            Queue<int> queue = new Queue<int>(threads);
            int currThread = 0;
            while (true)
            {
                int currTask = stack.Peek();
                currThread = queue.Peek();

                if (currTask == valueofthetask)
                {
                    break;
                }
                queue.Dequeue();
                if (currThread >= currTask)
                {
                    stack.Pop();
                    
                }

            }
            Console.WriteLine($"Thread with value {currThread} killed task {valueofthetask}");
        
            Console.WriteLine(String.Join(" ", queue));


        }
    }
}
