using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            //5 4 8 6 3 8 7 7 9
            //16

            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int capacityofaRack = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>(input);
            int counter = 0;
            int sumofRacks = 0;
            while (stack.Count > -1)
            {
                while (sumofRacks < capacityofaRack + 1)
                {
                    sumofRacks+= stack.Pop();
                    if (sumofRacks == capacityofaRack && stack.Count > 0)
                    {
                        sumofRacks = 0;
                        counter++;
                    }
                    else if (stack.Count == 0)
                    {
                        counter++;
                    }
                    else if (sumofRacks + stack.Peek() > capacityofaRack)
                    {
                        counter++;
                        sumofRacks = 0;
                    }
                    if (stack.Count == 0)
                    {
                        break;
                    }
                }
                break;
            }
            Console.WriteLine(counter);
        }
    }
}
