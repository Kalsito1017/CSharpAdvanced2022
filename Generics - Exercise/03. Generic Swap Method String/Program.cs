using System;
using System.Linq;

namespace _03._Generic_Swap_Method_String
{
    public class Program
    {
        static void Main(string[] args)
        {
            Swap<string> swap = new Swap<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                swap.Values.Add(input);
            }
            int[] indices = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            swap.Swaps(indices[0], indices[1]); 
            Console.WriteLine(swap.ToString());
        }
    }
}
