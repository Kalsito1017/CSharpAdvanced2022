using System;
using System.Linq;

namespace _02._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            for (int i = 0; i < 1; i++)
            {
                int numbers = input.Length;
                Console.WriteLine(numbers);
            }
            Console.WriteLine(input.Sum());


           
        }
        
    }
}
