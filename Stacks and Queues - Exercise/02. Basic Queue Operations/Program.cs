using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 2 13
            // 1 13 45 32 4


            int[] inputNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] numbersofElements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Queue<int> stack = new Queue<int>();
            int toPush = inputNumbers[0];
            int toPop = inputNumbers[1];
            int specialNumber = inputNumbers[2];
            for (int i = 0; i < toPush; i++)
            {
                stack.Enqueue(numbersofElements[i]);
            }
            for (int i = 0; i < toPop; i++)
            {
                stack.Dequeue();
            }
            if (stack.Contains(specialNumber))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count > 0)
            {
                Console.WriteLine(stack.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
