using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodfortheday = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Console.WriteLine(input.Max());
            Queue<int> queueOfOrders = new Queue<int>(input);
            while (queueOfOrders.Count > 0 && foodfortheday >= 0)
            {
                int currentOrderd = queueOfOrders.Peek();
                //1000 - 100
                if (foodfortheday - currentOrderd < 0)
                {
                    break;
                }
                //900
                foodfortheday -= currentOrderd;
                queueOfOrders.Dequeue();
            }
            if (queueOfOrders.Count > 0)
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queueOfOrders)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
