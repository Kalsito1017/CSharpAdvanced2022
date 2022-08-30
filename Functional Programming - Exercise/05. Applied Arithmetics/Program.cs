using System;
using System.Collections.Generic;
using System.Linq;
namespace _05._Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string input = Console.ReadLine();
            while (input != "end")
            {
                switch (input)
                {
                    case "add":
                        nums = nums.Select(x => x + 1).ToArray();
                        break;
                    case "multiply":
                        nums = nums.Select(x => x * 2).ToArray();
                        break;
                    case "subtract":
                        nums = nums.Select(x => x - 1).ToArray();
                        break;
                    case "print":
                        Console.WriteLine(string.Join(' ', nums));
                        break;
                }


                input = Console.ReadLine();
            }
        }
    }
}
