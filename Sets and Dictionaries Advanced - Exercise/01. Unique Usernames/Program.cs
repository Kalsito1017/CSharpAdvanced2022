using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
namespace _01._Unique_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            var line = int.Parse(Console.ReadLine());
            for (int i = 0; i < line; i++)
            {
                string names = Console.ReadLine();
                set.Add(names);
            }
            foreach (var name in set)
            {
                Console.WriteLine(name);
            }
        }
    }
}
