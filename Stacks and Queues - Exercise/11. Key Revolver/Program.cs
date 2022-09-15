using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int barrelSize = int.Parse(Console.ReadLine());
            int[] bulletsInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] locksInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int intelligence = int.Parse(Console.ReadLine());

            Queue<int> locks = new Queue<int>(locksInput);
            Stack<int> bullets = new Stack<int>(bulletsInput);

            int bulletsCounter = 0;

            while (locks.Count > 0 && bullets.Count > 0)
            {


                if (locks.Peek() < bullets.Peek())
                {
                    Console.WriteLine("Ping!");
                    bullets.Pop();
                }
                else
                {
                    Console.WriteLine("Bang!");
                    bullets.Pop();
                    locks.Dequeue();
                }
                bulletsCounter++;

                if (bullets.Count > 0 && bulletsCounter % barrelSize == 0)
                {
                    Console.WriteLine("Reloading!");
                }
            }

            if (bullets.Count == 0 && locks.Count != 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }

            if (locks.Count == 0)
            {
                int bulletCost = bulletsCounter * bulletPrice;
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${intelligence - bulletCost}");
            }
        }
    }
}
