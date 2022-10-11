using System;

namespace _08._Threeuple
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] pplandaddress = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] plandaddress = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] landaddress = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            TheeTuple<string, string, string> tuple = new TheeTuple<string, string, string>
            {
                Item1 = $"{pplandaddress[0]} {pplandaddress[1]}",
                Item2 = $"{pplandaddress[2]}",
                Item3 = $"{pplandaddress[3]}"
            };
            TheeTuple<string, int, bool> tuple1 = new TheeTuple<string, int,bool>
            {
                Item1 = $"{plandaddress[0]}",
                Item2 = int.Parse(plandaddress[1]),
                Item3 = (plandaddress[2] == "drunk")
            };
            TheeTuple<string, double, string> tuple2 = new TheeTuple<string, double, string>
            {
                Item1 = $"{landaddress[0]}",
                Item2 = double.Parse(landaddress[1]),
                Item3 = $"{landaddress[2]}"
            };
            
            Console.WriteLine(tuple);
            Console.WriteLine(tuple1);
            Console.WriteLine(tuple2);

        }
    }
}
