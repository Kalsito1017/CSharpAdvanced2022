using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Birthday_Celebration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] singleguest = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] plates = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Queue<int> guests = new Queue<int>(singleguest);
            Stack<int> plate = new Stack<int>(plates);
            int wastedfood = 0;
            while (guests.Count > 0 && plate.Count > 0)
            {
                int currPlate = plate.Pop();
                int currguest = guests.Dequeue();
            
                if (currPlate >= currguest)
                {
                    wastedfood += currPlate - currguest;
                }
                else
                {
                    currguest -= currPlate;
                    while (currguest > 0)
                    {
                        currPlate = plate.Pop();
                        if (currPlate >= currguest)
                        {
                            wastedfood += currPlate - currguest;
                        }
                        currguest -= currPlate;
                    }
                }
               

            }
            if (guests.Count ==0)
            {
                Console.WriteLine($"Plates: {string.Join(' ', plate)}");
            }
            else
            {
                Console.WriteLine($"Guests: {string.Join(' ', guests)}");
            }
            Console.WriteLine($"Wasted grams of food: {wastedfood}");

        }
    }
}
