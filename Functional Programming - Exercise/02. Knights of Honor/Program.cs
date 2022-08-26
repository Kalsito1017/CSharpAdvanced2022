using System;

namespace _02._Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ");
            foreach (string name in names)
            {
                Console.WriteLine($"Sir {name}");
            }
        }
    }
}
