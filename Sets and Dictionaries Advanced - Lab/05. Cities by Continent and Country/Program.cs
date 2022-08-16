using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


namespace _05._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int line = int.Parse(Console.ReadLine());
            var things = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < line; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string continents = input[0];
                string countries = input[1];
                string cities = input[2];
                if (!things.ContainsKey(continents))
                {
                    things.Add(continents, new Dictionary<string, List<string>>());
                }
                if (!things[continents].ContainsKey(countries))
                {
                    things[continents][countries] = new List<string>();
                }
                
                things[continents][countries].Add(cities);
                
                

            }
            foreach (var continent in things)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var countries in continent.Value)
                {
                    Console.WriteLine($"  {countries.Key} -> {string.Join(", ", countries.Value)}");
                        
                }
            }



        }
    }
}
