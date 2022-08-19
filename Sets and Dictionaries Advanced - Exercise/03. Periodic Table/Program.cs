using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> elements = new SortedSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] chemicalcompounds = Console.ReadLine().Split(" ");
                foreach (string chemicalcompound in chemicalcompounds)
                {
                    elements.Add(chemicalcompound);
                }
            }
            Console.WriteLine(string.Join(" ", elements));
            
        }
    }
}
