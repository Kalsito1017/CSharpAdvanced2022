using System;

namespace _01._Action_Print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
