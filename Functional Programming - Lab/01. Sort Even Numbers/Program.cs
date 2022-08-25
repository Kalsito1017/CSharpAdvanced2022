using System;
using System.Linq;

namespace _01._Sort_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            
            var newInput = input.Where(EvenNumber).OrderBy(x => x);
            Console.WriteLine(String.Join(", ", newInput));

          
            
        }
        static bool EvenNumber(int x)
        {
            return x % 2 == 0;
        }
    }
}
