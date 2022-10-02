using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _01._Tiles_Master
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] whitetiles = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] greyiles = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(greyiles);
            Stack<int> stack = new Stack<int>(whitetiles);
            Dictionary<string, int[]> places = new Dictionary<string, int[]>
           {
               {"Countertop", new[] {60, 0}},
               {"Floor", new[] {0, 0}},
               {"Oven", new[] {50, 0}},
               {"Sink", new[] {40, 0}},
               {"Wall", new[] {70, 0}}
           };
            while (queue.Count > 0 && stack.Count > 0)
            {
                int currwhiteTail = stack.Pop();
                int currgreyTail = queue.Dequeue();
                if (currgreyTail == currwhiteTail)
                {
                    int floor = currwhiteTail + currgreyTail;
                    if (places.Any(p => p.Value[0] == floor))
                    {
                        places.First(p => p.Value[0] == floor).Value[1]++;
                    }
                    else
                    {
                        places["Floor"][1]++;
                    }
                }
                else
                {
                    stack.Push(currwhiteTail / 2);
                    queue.Enqueue(currgreyTail);
                }
            }
            if (stack.Any())
            {
                Console.WriteLine($"White tiles left: {string.Join(", ", stack)}");
            }
            if (stack.Count == 0)
            {
                Console.WriteLine("White tiles left: none");
            }
            if (queue.Any())
            {
                Console.WriteLine($"Grey tiles left: {string.Join(", ", queue)}"); 
            }
            if (queue.Count == 0)
            {
                Console.WriteLine("Grey tiles left: none");
            }
            foreach (var place in places.OrderByDescending(p => p.Value[1]).ThenBy(p => p.Key))
            {
                if (place.Value[1] > 0)
                {
                    Console.WriteLine($"{place.Key}: {place.Value[1]}");
                }
            }
        }
    }
}
