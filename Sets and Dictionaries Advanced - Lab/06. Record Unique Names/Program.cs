
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System;

namespace _06._Record_Unique_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
           HashSet<string> uniqueNames = new HashSet<string>();
            int line = int.Parse(Console.ReadLine());
            for (int i = 0; i < line; i++)
            {
                string names = Console.ReadLine();
                uniqueNames.Add(names);
            }
            foreach (var name in uniqueNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
