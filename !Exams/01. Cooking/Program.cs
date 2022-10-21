using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Cooking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] liquid = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int
                .Parse).ToArray();
            int[] ingredient = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int
                .Parse).ToArray();
            Stack<int> ingredients = new Stack<int>(ingredient);
            Queue<int> liquids = new Queue<int>(liquid);
            
            SortedDictionary<string, int[]> products = new SortedDictionary<string, int[]>
            {
               {"Bread", new[] {25, 0}},
                {"Cake", new[] {50, 0}},
                {"Pastry", new[] {75, 0}},
                {"Fruit Pie", new[] {100, 0}}

            };
            bool isCoocked = false;
            while (ingredients.Count > 0 && liquids.Count > 0)
            {
                int curringredient = ingredients.Pop();
                int currliquid = liquids.Dequeue();
                int sum = curringredient + currliquid;
                isCoocked = false;
                foreach (var item in products)
                {
                    if (item.Value[0] == sum)
                    {
                        item.Value[1]++;
                        isCoocked = true;
                        continue;
                    }
                }
                if (!isCoocked)
                {  
                    ingredients.Push(curringredient + 3);
                }
            }
            Console.WriteLine(products.Any(f => f.Value[1] == 0)
               ? "Ugh, what a pity! You didn't have enough materials to cook everything."
               : "Wohoo! You succeeded in cooking all the food!");
            Console.WriteLine(liquids.Count == 0
                ? "Liquids left: none"
                : $"Liquids left: {string.Join(", ", liquids)}");

            Console.WriteLine(ingredients.Count == 0
                ? "Ingredients left: none"
                : $"Ingredients left: {string.Join(", ", ingredients)}");
            foreach (var item in products)
            {
                Console.WriteLine($"{item.Key}: {item.Value[1]}");
            }
        }
    }
}
