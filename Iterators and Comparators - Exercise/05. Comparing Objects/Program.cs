using System;
using System.Collections.Generic;

namespace _05._Comparing_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] argss = command.Split(" ");
                string name = argss[0];
                int age = int.Parse(argss[1]);
                string town = argss[2];
                list.Add(new Person(name, age, town));
                command = Console.ReadLine();
            }
            int n = int.Parse(Console.ReadLine()) - 1;
            int matches = 0;
            int notMatch = 0;
            foreach (var item in list)
            {
                int result = list[n].CompareTo(item);
                if (result == 0)
                {
                    matches++;
                }
                else
                {
                    notMatch++;
                }
            }
            Console.WriteLine(matches == 1 ? "No matches" : $"{matches} {notMatch} {list.Count}");
        }
    }
}
