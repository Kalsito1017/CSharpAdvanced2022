using _05._Comparing_Objects;
using System;
using System.Collections.Generic;

namespace _06._Equality_Logic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Person> set = new HashSet<Person>();
            SortedSet<Person> set2 = new SortedSet<Person>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string info = Console.ReadLine();
                string[] currargs = info.Split(" ");
                string name = currargs[0];
                int age = int.Parse(currargs[1]);
                Person person = new Person(name, age);
                set.Add(person);
                set2.Add(person);
            }
            Console.WriteLine(set.Count);
            Console.WriteLine(set2.Count);
        }
    }
}
