using System;
using System.Linq;

namespace _03._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).OrderByDescending(n => n).ToArray();
            
            int counter = 0;
            counter = arr.Length < 3
                ? arr.Length : 3;
            Console.WriteLine(string.Join(" ", arr.Take(counter)));
        }
    }
}
