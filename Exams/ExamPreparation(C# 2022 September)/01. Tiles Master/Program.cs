using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Tiles_Master
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> whiteTiles = new Stack<int>();
            Queue<int> greyTiles = new Queue<int>();
            int[] whitetilesInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] greytilesInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < whitetilesInput.Length; i++)
            {
                whiteTiles.Push(whitetilesInput[i]);
            }
            for (int i = 0; i < greytilesInput.Length; i++)
            {
                greyTiles.Enqueue(greytilesInput[i]);
            }
            Dictionary<string, int> locationsList = new Dictionary<string, int>()
            {
                {"Sink", 40},
                {"Oven", 50},
                {"Countertop", 60},
                {"Wall", 70}
            };
            Dictionary<string, int> locationsTiles = new Dictionary<string, int>();
            while (true)
            {
                if (!whiteTiles.Any() || !greyTiles.Any())
                {
                    break;
                }

                bool isFitting = false;
                int whiteTileCurrent = whiteTiles.Peek();
                int greyTileCurrent = greyTiles.Peek();

                if (whiteTileCurrent == greyTileCurrent)
                {
                    int newTileCurrent = whiteTileCurrent + greyTileCurrent;
                    foreach (var location in locationsList)
                    {
                        if (location.Value == newTileCurrent)
                        {
                            if (!locationsTiles.ContainsKey(location.Key))
                            {
                                locationsTiles.Add(location.Key, 1);
                            }
                            else
                            {
                                locationsTiles[location.Key]++;
                            }

                            isFitting = true;
                            break;
                        }
                    }

                    if (!isFitting)
                    {
                        if (!locationsTiles.ContainsKey("Floor"))
                        {
                            locationsTiles.Add("Floor", 1);
                        }
                        else
                        {
                            locationsTiles["Floor"]++;
                        }
                    }


                    if (whiteTiles.Any())
                    {
                        whiteTiles.Pop();
                    }
                    if (greyTiles.Any())
                    {
                        greyTiles.Dequeue();
                    }
                }
                else
                {
                    if (whiteTiles.Any())
                    {
                        whiteTiles.Push(whiteTiles.Pop() / 2);
                    }
                    if (greyTiles.Any())
                    {
                        greyTiles.Enqueue(greyTiles.Dequeue());

                    }
                }
            }

            var whiteTilesLeft = whiteTiles.Count == 0 ? "none" : string.Join(", ", whiteTiles);
            var greyTilesLeft = greyTiles.Count == 0 ? "none" : string.Join(", ", greyTiles);

            Console.WriteLine($"White tiles left: {whiteTilesLeft}");
            Console.WriteLine($"Grey tiles left: {greyTilesLeft}");
            foreach (var location in locationsTiles.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{location.Key}: {location.Value}");
            }




        }
    }
}
