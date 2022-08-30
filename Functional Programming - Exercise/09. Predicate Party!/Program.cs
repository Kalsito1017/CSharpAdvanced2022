using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Predicate_Party_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<string> People = Console.ReadLine().Split().ToList();
            string command = Console.ReadLine();
            while (command != "Party!")
            {
                string[] commandInfo = command.Split(" ");
                Predicate<string> predicate = GetPredicate(commandInfo[1], commandInfo[2]);
                if (commandInfo[0] == "Remove")
                {
                    People.RemoveAll(predicate);
                }
                else if (commandInfo[0] == "Double")
                {
                    List<string> doubleNames = People.FindAll(predicate);
                    if (doubleNames.Any())
                    {
                        int index = People.FindIndex(predicate);
                        People.InsertRange(index, doubleNames);
                    }
                }
                command = Console.ReadLine();
            }
            if (People.Any())
            {
                Console.WriteLine($"{string.Join(", ", People) } are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static Predicate<string> GetPredicate(string commandInfo, string param)
        {
            if (commandInfo == "StartsWith")
            {
                return x => x.StartsWith(param);
            }
            if (commandInfo == "EndsWith")
            {
                return x => x.EndsWith(param);
            }
            int lenght = int.Parse(param);
            return x => x.Length == lenght;
        }
    }
}
