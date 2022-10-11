using System;

namespace _06._Generic_Count_Method_Double
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counts<double> elements = new Counts<double>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double element = double.Parse(Console.ReadLine());
                elements.List.Add(element);
            }
            double itemTocompare = double.Parse(Console.ReadLine());
            Console.WriteLine(elements.Count(itemTocompare));
        }
    }
}
