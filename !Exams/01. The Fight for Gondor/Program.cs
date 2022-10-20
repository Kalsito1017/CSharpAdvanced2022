using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._The_Fight_for_Gondor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wavesoforcs = int.Parse(Console.ReadLine());
            int[] plate = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int
                .Parse).ToArray();
            Stack<int> orcs = new Stack<int>();
            Queue<int> plates = new Queue<int>(plate);
            for (int i = 0; i < wavesoforcs; i++)
            {
                int[] powerofeachork = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int
                .Parse).ToArray();
                foreach (var item in powerofeachork)
                {
                    orcs.Push(item);
                }
                if ((i + 1) % 3 == 0)
                {
                    int newplate = int.Parse(Console.ReadLine());
                    plates.Enqueue(newplate);
                }
                while(plates.Count > 0 && orcs.Count > 0)
                {
                    int currentPlate = plates.Dequeue();
                    int currOrc = orcs.Pop();
                    if (currOrc > currentPlate)
                    {
                        currOrc -= currentPlate;
                        orcs.Push(currOrc);
                    }
                    else if (currOrc < currentPlate)
                    {
                        currentPlate -= currOrc;
                        List<int> newq = new List<int>(plates);
                        newq.Insert(0, currentPlate);
                        plates = new Queue<int>(newq);
                    }
                }
                if (plates.Count == 0)
                {
                    break;
                }
            }
            if (plates.Count > 0)
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
            }
            else
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                Console.WriteLine($"Orcs left: {string.Join(", ", orcs)}");
            }



        }
    }
}
