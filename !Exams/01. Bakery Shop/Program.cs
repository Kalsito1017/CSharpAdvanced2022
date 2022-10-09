using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Bakery_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] amountofwater = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
            double[] amountofflour = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
            Stack<double> flour = new Stack<double>(amountofflour);
            Queue<double> water = new Queue<double>(amountofwater);
            Dictionary<string, int[]> products = new Dictionary<string, int[]>
            {
                {"Croissant", new int[3]{50, 50, 0} },
                {"Muffin", new int[3]{40, 60, 0} },
                {"Baguette", new int[3]{30, 70,0} },
                {"Bagel", new int[3]{20, 80, 0} }
            };
            while (water.Count > 0 && flour.Count > 0)
            {
                double currWater = water.Peek();
                double currFlour = flour.Peek();
                double percentage = currWater / (currWater + currFlour) * 100;
                bool isThereaProduct = false;
                foreach (var product in products)
                {
                    if ((int)percentage == product.Value[0])
                    {
                        product.Value[2]++;
                        flour.Pop();
                        water.Dequeue();
                        isThereaProduct = true;
                        break;
                    } 
                }
                if (isThereaProduct)
                {
                    continue;
                }
                products["Croissant"][2]++;
                if (currWater > currFlour)
                {
                    flour.Pop();
                    water.Dequeue();
                }
                else if (currWater < currFlour)
                {
                    water.Dequeue();
                    currFlour -= currWater;
                    flour.Pop();
                    flour.Push(currFlour);
                }
            }
            foreach (var product in products.Where(p => p.Value[2] > 0).OrderByDescending(P => P.Value[2]).ThenBy(p => p.Key))
            {
                Console.WriteLine($"{product.Key}: {product.Value[2]}");
            }
            Console.WriteLine(water.Count == 0 ? "Water left: None" : $"Water left: {string.Join(", ", water)}");
            Console.WriteLine(flour.Count == 0 ? "Flour left: None" : $"Flour left: {string.Join(", ", flour)}");
        }
    }
}
