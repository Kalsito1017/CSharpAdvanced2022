using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 2 13
           // 1 13 45 32 4

            
            int[] inputNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] numbersofElements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();
            int toPush = inputNumbers[0];
            int toPop = inputNumbers[1];
            int specialNumber = inputNumbers[2];
            for (int i = 0; i < toPush; i++)
            {
                stack.Push(numbersofElements[i]);
            }
            for (int i = 0; i < toPop; i++)
            {
                stack.Pop();
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
