using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._The_Party_Reservation_Filter_Module
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            List<string> People = Console.ReadLine().Split().ToList();
            var dictionary = new Dictionary<string, Predicate<string>>();

            string command = Console.ReadLine();
            while (command != "Print")
            {
                string[] commandInfo = command.Split(';');
                string action = commandInfo[0];
                string predicateAction = commandInfo[1];
                string value = commandInfo[2];
                string key = predicateAction + "_" + action;
                if (action == "Add filter")
                {
                    Predicate<string> predicate = GetPredicate(predicateAction, value);
                    dictionary.Add(key, predicate);
                }
                else
                {
                   dictionary.Remove(key);
                }
                command = Console.ReadLine();
            }
            foreach (var (key, predicate) in dictionary)
            {
                People.RemoveAll(predicate);
            }
            Console.WriteLine(String.Join(" ", People));
        }

        private static Predicate<string> GetPredicate(string commandInfo, string param)
        {
            if (commandInfo == "Start with")
            {
                return x => x.StartsWith(param);
            }
            if (commandInfo == "Ends with")
            {
                return x => x.EndsWith(param);
            }
            if (commandInfo == "Contains")
            {
                return x => x.Contains(param);
            }
            int lenght = int.Parse(param);
            return x => x.Length == lenght;
        }
    }
}
