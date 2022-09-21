using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Warm_Winter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] hats = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
         
            int[] scarfs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(scarfs);
           
            Stack<int> stack = new Stack<int>(hats);
            List<int> list = new List<int>();
            while (queue.Count > 0 && stack.Count > 0)
            {
                int currentHat = stack.Pop();
                int currentscarf = queue.Peek();
                if (currentHat > currentscarf)
                {
                    int sum = currentHat + currentscarf;
                    list.Add(sum);
                    queue.Dequeue();
                }
                else if (currentscarf == currentHat)
                {
                    queue.Dequeue();
                    stack.Push(currentscarf + 1);

                }
                
            }
            Console.WriteLine($"The most expensive set is: {list.Max()}");
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
