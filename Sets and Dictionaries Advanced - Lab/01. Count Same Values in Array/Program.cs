using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //example -2.5 4 3 -2.5 -5.5 4 3 3 -2.5 3

            var line = Console.ReadLine();
            var numbersAsStringList = line.Split(' ');

            var dic = new Dictionary<double, int>();
            foreach (var numberAsString in numbersAsStringList)
            {
                double number = double.Parse(numberAsString);
                if (!dic.ContainsKey(number))
                {
                    dic.Add(number, 1);
                }
                else
                {
                    dic[number]++;
                }
            }
            foreach (var number in dic)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }


        }
    }
}
