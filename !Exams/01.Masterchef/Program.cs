using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Masterchef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ingredients = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] freshnesslevel = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
           SortedDictionary<string, int[]> products = new SortedDictionary<string, int[]>
            {
                {"Dipping sauce", new []{150, 0} },
                {"Green salad", new []{250, 0} },
                {"Chocolate cake", new []{300, 0} },
                {"Lobster", new []{400, 0} }
            };
            Stack<int> stack = new Stack<int>(freshnesslevel);
            Queue<int> queue = new Queue<int>(ingredients);
            while (stack.Count > 0 && queue.Count > 0)
            {
                int currIngredient = queue.Dequeue();
                if (currIngredient == 0)
                {
                    continue;
                }
                int currFreshness = stack.Pop();
                int result = currIngredient * currFreshness;
                bool isCoocked = false;
                foreach (var dish in products)
                {
                    if (dish.Value[0] == result)
                    {
                        dish.Value[1]++;
                        
                        isCoocked = true;
                       
                    }
                }
                if (!isCoocked)
                {
                    currIngredient += 5;
                    queue.Enqueue(currIngredient);
                }

            }
            if (products.Count(d => d.Value[1] > 0) >= 4)
            {
                Console.WriteLine($"Applause! The judges are fascinated by your dishes!");
            }
            else
            {
                Console.WriteLine($"You were voted off. Better luck next year.");
            }
            if (queue.Count > 0)
            {
                Console.WriteLine($"Ingredients left: {queue.Sum()}");
            }
            foreach (var dish in products.Where(d => d.Value[1] > 0))
            {
                Console.WriteLine($" # {dish.Key} --> {dish.Value[1]}");
            }
            






        }
    }
}
