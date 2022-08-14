using System;
using System.Collections.Generic;
using System.Linq;
namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = new SortedDictionary<string, Dictionary<string, double>>();  
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "Revision")
                {
                    break;
                }
                var parts = line.Split(", ");
                var supermarket = parts[0];
                var product = parts[1];
                var price = double.Parse(parts[2]);
                if (!products.ContainsKey(supermarket))
                {
                   products.Add(supermarket, new Dictionary<string, double>());
                }
                if (!products[supermarket].ContainsKey(product))
                {
                    products[supermarket].Add(product, price);
                }
                else
                {
                    products[supermarket][product] = price;
                }
            }
            foreach (var supermarket in products)
            {
                Console.WriteLine($"{supermarket.Key}->");
                foreach (var product in supermarket.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
