using System;

namespace DateModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();
            int days = DateModifier.CalculateDateDiffInDays(firstDate, secondDate);
            Console.WriteLine(days);

        }
    }
}
