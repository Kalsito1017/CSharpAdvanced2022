using System;
using System.Linq;

namespace _04._Generic_Swap_Method_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Swap<int> swap = new Swap<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                swap.Values.Add(input);
            }
            int[] indices = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            swap.Swaps(indices[0], indices[1]);
            Console.WriteLine(swap.ToString());
        }

    }
}
