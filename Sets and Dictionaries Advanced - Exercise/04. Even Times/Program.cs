using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
namespace _04._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> numberss = new Dictionary<int, int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                 int  numbers = int.Parse(Console.ReadLine());
                if (!numberss.ContainsKey(numbers))
                {
                    numberss.Add(numbers, 0)
;                }
                numberss[numbers]++;
            }
            //int number = numberss.Where(x => x.Value % 2 == 0).FirstOrDefault().Key;
            //int number = numberss.FirstOrDefault(x => x.Value % 2 == 0).Key;
            foreach (var (key, value)  in numberss)
            {
                if (value % 2 == 0)
                {
                    Console.WriteLine(key);
                    break;
                }
            }
        }
    }
}
