using System;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int,bool> Divisible = (x, y) => x % y == 0;
            int[] nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int number = int.Parse(Console.ReadLine());
            int[] result = nums.Where(x => !Divisible(x, number)).Reverse().ToArray();
            Console.WriteLine(string.Join(" ", result));
            
        }
    }
}
