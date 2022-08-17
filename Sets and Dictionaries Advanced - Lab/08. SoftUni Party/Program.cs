using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> guestList = new HashSet<string>();

            string cmdSheets;
            while ((cmdSheets = Console.ReadLine()) != "PARTY")
            {
                string guestListNumber = cmdSheets;

                if (guestListNumber.Length == 8)
                {
                    guestList.Add(guestListNumber);
                }
            }

            string cmdParty;
            while ((cmdParty = Console.ReadLine()) != "END")
            {
                string guestNumber = cmdParty;
                if (guestList.Contains(guestNumber))
                {
                    guestList.Remove(guestNumber);
                }
            }

            Console.WriteLine(guestList.Count);

            foreach (string guest in guestList.Where(g => char.IsDigit(g[0])))
            {
                Console.WriteLine(guest);
            }
            foreach (string guest in guestList.Where(g => !char.IsDigit(g[0])))
            {
                Console.WriteLine(guest);
            }

        }
    }
}
