using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var parking = new HashSet<string>();
            while (input != "END")
            {
                var inputParams = Regex.Split(input, ", ");
                if (inputParams[0] == "IN")
                {
                    parking.Add(inputParams[1]);
                }
                else
                {
                    parking.Remove(inputParams[1]);
                }
                input = Console.ReadLine();
            }
            foreach (var item in parking)
            {
                Console.WriteLine(item);
            }
            if (parking.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
