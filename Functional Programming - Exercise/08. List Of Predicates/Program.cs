using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._List_Of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int n = int.Parse(Console.ReadLine());
            int[] nums = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            int[] allnumbers = Enumerable.Range(1, n).ToArray();
            List<Predicate<int>> predicate = new List<Predicate<int>>();
            foreach (var number in nums)
            {
                predicate.Add(x => x % number == 0);
                
            }
            foreach (var item in allnumbers)
            {
                bool isDivisible = true;
                foreach (var predicateee in predicate)
                {
                    if (!predicateee(item)) 
                    {
                        isDivisible = false;

                            break;

                    }
                }
                if (isDivisible)
                {
                    Console.Write(item + " ");
                }
            }
            
        }
    }
}
