using System;

namespace _05._Generic_Count_Method_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counts<string> elements = new Counts<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string element = Console.ReadLine();
                elements.List.Add(element);
            }
            string itemTocompare = Console.ReadLine();
            Console.WriteLine(elements.Count(itemTocompare));
        }
    }
}
