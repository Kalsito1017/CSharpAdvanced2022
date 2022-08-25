using System;
using System.Linq;
namespace _04._Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(", ").Select(double.Parse).ToArray();
            foreach (var number in numbers)
            {
                double rightnumber = number * 0.2 + number;
                Console.WriteLine($"{rightnumber:F2}");
            }
            
        }
    }
}
