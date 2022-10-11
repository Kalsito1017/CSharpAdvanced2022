using System;

namespace _07._Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] pplandaddress = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            string[] plandaddress = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] landaddress = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Tuple<string, string> tuple = new Tuple<string, string>
            {
                Item1 = $"{pplandaddress[0]} {pplandaddress[1]}",
                Item2 = $"{pplandaddress[2]}"
            };
            Tuple<string, int> tuple1 = new Tuple<string, int>
            {
                Item1 = $"{plandaddress[0]}",
                Item2 = int.Parse(plandaddress[1])
            };
            Tuple<int, double> tuple2 = new Tuple<int, double>
            {
                Item1 = int.Parse(landaddress[0]),
                Item2 = double.Parse(landaddress[1])
            };
            Console.WriteLine(tuple);
            Console.WriteLine(tuple1);
            Console.WriteLine(tuple2);




        }
    }
}
