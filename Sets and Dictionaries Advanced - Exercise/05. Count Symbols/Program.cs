using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            SortedDictionary<char, int> dictionary = new SortedDictionary<char, int>();


            foreach (char ch in text)
            {
                if (!dictionary.ContainsKey(ch))
                {
                    dictionary[ch] = 0;
                }
                dictionary[ch]++;
            }
            foreach (var (ch,time) in dictionary)
            {
                Console.WriteLine($"{ch}: {time} time/s");
            }
        }
    }
}
