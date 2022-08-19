using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = arr[0];
            int m = arr[1];
            HashSet<int> leftset = new HashSet<int>();
            HashSet<int> rightset = new HashSet<int>();
            // 3 5 7
            for (int i = 0; i < n; i++)
            {
                int firstnumers = int.Parse(Console.ReadLine());
                leftset.Add(firstnumers);
            }
            // 2 3 5
            for (int i = 0; i < m; i++)
            {
                int secondnumbers = int.Parse(Console.ReadLine());
                rightset.Add(secondnumbers);
            }
            List<int> list = leftset.Intersect(rightset).ToList();
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
