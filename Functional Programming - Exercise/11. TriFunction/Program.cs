using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace _11._TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names
                = Console.ReadLine().Split().ToList();
            //Kaloyan , 350, bool
            Func<string, int, bool> isLargerOrEqual = (name, ASCIISum) => name.Sum (x => x) >= ASCIISum;
            //names,IslargerOrEqualToNameAscii
            Func<List<string>, int, Func<string, int, bool>, string> desiredName = (allNames, number, func) => allNames.FirstOrDefault(x => func(x, number));
            string result = desiredName(names, n, isLargerOrEqual);
            Console.WriteLine(result);
          

        }
    }
}
