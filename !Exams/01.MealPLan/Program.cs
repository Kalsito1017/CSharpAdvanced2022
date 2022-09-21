using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MealPlan
{
    internal class MealPlan
    {
        static void Main(string[] args)
        {
            string[] mealsthatJohncaneat = Console.ReadLine().Split(" ");
            int[] maximumcaloriesintakeperday = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Stack<int> calories = new Stack<int>(maximumcaloriesintakeperday);
            Queue<string> meals = new Queue<string>(mealsthatJohncaneat);
            int currDailyCalories = 0;
          
            Dictionary<string, int> mealCalories = new Dictionary<string, int>
            {
                {"salad", 350},
                {"soup", 490},
                {"pasta", 680},
                {"steak", 790}
             };

            while (calories.Count != 0 && meals.Count != 0)
            {
                int diff = currDailyCalories;
                currDailyCalories = calories.Peek() + diff;
                while (currDailyCalories > 0)
                {
                    if (meals.Count == 0)
                    {
                        calories.Pop();
                        calories.Push(currDailyCalories);
                        
                        Console.WriteLine($"John had {mealsthatJohncaneat.Length} meals.");
                        Console.WriteLine($"For the next few days, he can eat {string.Join(", ", calories)} calories.");
                        return;
                    }
                    string currMeal = meals.Dequeue();
                    currDailyCalories -= mealCalories[currMeal];
                }
                calories.Pop();
            }



            Console.WriteLine($"John ate enough, he had {mealsthatJohncaneat.Length - meals.Count} meals.");
            Console.WriteLine($"Meals left: {string.Join(", ", meals)}.");




        }
    }
}
