using System;
using System.Linq;
using System.Collections.Generic;

namespace BaristaContest
{
    public class BaristaContest
    {
        static void Main()
        {
            Queue<int> coffeeQuantities = new Queue<int>();
            Stack<int> milkQuantities = new Stack<int>();
            int[] coffeeQuantitiesInput = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] milkQuantititesInput = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < coffeeQuantitiesInput.Length; i++)
            {
                coffeeQuantities.Enqueue(coffeeQuantitiesInput[i]);
            }
            for (int i = 0; i < milkQuantititesInput.Length; i++)
            {
                milkQuantities.Push(milkQuantititesInput[i]);
            }
            bool isDrinkMade = false;
            Dictionary<string, int> drinksMade = new Dictionary<string, int>();

            Dictionary<string, int> drinksList = new Dictionary<string, int>()
            {
                {"Cortado", 50 },
                {"Espresso", 75 },
                {"Capuccino", 100 },
                {"Americano", 150 },
                {"Latte", 200 },
            };
            while (true)
            {
                if (!coffeeQuantities.Any() || !milkQuantities.Any())
                {
                    break;
                }
                isDrinkMade = false;
                int milkQuantityCurrent = milkQuantities.Peek();
                int coffeeQuantityCurrent = coffeeQuantities.Peek();
                int sumMilkCoffee = milkQuantityCurrent + coffeeQuantityCurrent;

                foreach (var drink in drinksList)
                {
                    if (drink.Value == sumMilkCoffee)
                    {
                        if (!drinksMade.ContainsKey(drink.Key))
                        {
                            drinksMade.Add(drink.Key, 1);
                        }
                        else
                        {
                            drinksMade[drink.Key]++;
                        }

                        milkQuantities.Pop();
                        coffeeQuantities.Dequeue();
                        isDrinkMade = true;
                        break;
                    }
                }
                if (!isDrinkMade)
                {
                    if (coffeeQuantities.Any())
                    {
                        coffeeQuantities.Dequeue();
                    }
                    if (milkQuantities.Any())
                    {
                        milkQuantities.Push(milkQuantities.Pop() - 5);
                    }
                }
            }
            //first line
            var firstLine = coffeeQuantities.Count == 0 && milkQuantities.Count == 0
                ? "Nina is going to win! She used all the coffee and milk!"
                : "Nina needs to exercise more! She didn't use all the coffee and milk!";
            Console.WriteLine(firstLine);
            //second line
            var coffeeLeft = coffeeQuantities.Count == 0 ? "none" : String.Join(", ", coffeeQuantities);
            Console.WriteLine($"Coffee left: {coffeeLeft}");
            //third line
            var milkLeft = milkQuantities.Count == 0 ? "none" : String.Join(", ", milkQuantities);
            Console.WriteLine($"Milk left: {milkLeft}");

            //fourth line
            foreach (var drink in drinksMade.OrderBy(x => x.Value).ThenByDescending(x => x.Key))
            {
                Console.WriteLine($"{drink.Key}: {drink.Value}");
            }
        }
    }
}
