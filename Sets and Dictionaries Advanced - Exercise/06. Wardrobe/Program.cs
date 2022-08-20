using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
           var wardrobe = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                string[] clothes = input[1].Split(',');
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }
                foreach (var item in clothes)
                {
                    if (!wardrobe[color].ContainsKey(item))
                    {
                        wardrobe[color].Add(item, 0);
                    }
                    wardrobe[color][item]++;
                }

            }
            string[] targetClothe = Console.ReadLine().Split();
            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var (clothe, value) in color.Value)
                {
                    if (clothe == targetClothe[1] && color.Key == targetClothe[0])
                    {
                        Console.WriteLine($"* {clothe} - {value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothe} - {value}");
                    }
                }
            }
        }
    }
}
