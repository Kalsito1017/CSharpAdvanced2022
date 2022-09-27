using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._The_Party_Reservation_Filter_Module
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> guests = Console.ReadLine().Split().ToList();

            List<string> commands = new List<string>();

            string cmd;
            while ((cmd = Console.ReadLine()) != "Print")
            {
                if (cmd.StartsWith("Add filter"))
                {
                    commands.Add(cmd);
                }
                else if (cmd.StartsWith("Remove filter"))
                {
                    cmd = cmd.Replace("Remove", "Add");
                    commands.Remove(cmd);
                }
            }

            foreach (var comm in commands)
            {
                string filterType = comm.Split(";")[1];
                string filterParam = comm.Split(";")[2];

                Predicate<string> startWith = str => str.StartsWith(filterParam);
                Predicate<string> endsWith = str => str.EndsWith(filterParam);
                Predicate<string> isInLength = str => str.Length == int.Parse(filterParam);
                Predicate<string> contains = str => str.Contains(filterParam);

                if (filterType == "Starts with")
                {
                    guests.RemoveAll(startWith);
                }
                else if (filterType == "Ends with")
                {
                    guests.RemoveAll(endsWith);
                }
                else if (filterType == "Length")
                {
                    guests.RemoveAll(isInLength);
                }
                else if (filterType == "Contains")
                {
                    guests.RemoveAll(contains);
                }
            }

            Console.WriteLine(string.Join(" ", guests));
        }

       
    }
}
