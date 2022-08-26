using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split();
            int start = int.Parse(input[0]);
            int end = int.Parse(input[1]);

            List<int> numbers = new List<int>();

            for (int i = start; i <= end; i++)
            {
                numbers.Add(i);
            }

            string command = Console.ReadLine();

            Predicate<int> isOdd = num => num % 2 != 0;
            Predicate<int> isEven = num => num % 2 == 0;

            switch (command)
            {
                case "odd":
                    Console.WriteLine(string.Join(" ", numbers.FindAll(isOdd)));
                    break;

                case "even":
                    Console.WriteLine(string.Join(" ", numbers.FindAll(isEven)));
                    break;
            }

        }
    }
}
