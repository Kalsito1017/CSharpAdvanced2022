using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Lootbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstlootbox = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] secondlootbox = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Queue<int> firstbox = new Queue<int>(firstlootbox); 
            Stack<int> secondbox = new Stack<int>(secondlootbox);
            int sum = 0;
            while (firstbox.Count > 0 && secondbox.Count > 0)
            {
                int firstitem = firstbox.Peek();
                int seconditem = secondbox.Pop();
                int currsum = firstitem + seconditem;
                if (currsum % 2 == 0)
                {
                    
                    sum += currsum;
                    firstbox.Dequeue();
                    
                }
                else
                {
                    firstbox.Enqueue(seconditem);
                }
            }
            if (firstbox.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            if (secondbox.Count == 0)
            {
                Console.WriteLine("Second lootbox is empty");
            }
            if (sum >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {sum}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {sum}");
            }
           
        }
    }
}
