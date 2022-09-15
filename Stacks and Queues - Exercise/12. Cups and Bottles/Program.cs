using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace _12_Cups_and_Bottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cupscapacity = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] filledbottles = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> bottles = new Stack<int>(filledbottles);
            Queue<int> cups = new Queue<int>(cupscapacity);

            int wastedLiters = 0;
            while (bottles.Count > 0 && cups.Count > 0)
            {
                int currentBottle = bottles.Pop();
                int currentCup = cups.Dequeue();
                if (currentBottle - currentCup >= 0)
                {
                    wastedLiters += currentBottle - currentCup;
                    continue;
                }
                currentCup -= currentBottle;
                while (bottles.Count > 0)
                {
                    int bottle = bottles.Pop();
                    if (bottle - currentCup >= 0)
                    {
                        wastedLiters += bottle - currentCup;
                        break;
                    }
                    currentCup -= bottle;
                }
                // 3 + 2 + 8 + 15 + 3


            }
            if (bottles.Count > 0)
            {
                Console.WriteLine($"Bottles: {String.Join(" ", bottles)}");
            }
            else
            {
                Console.WriteLine($"Cups: {String.Join(" ", cups)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedLiters}");



        }
    }
}
