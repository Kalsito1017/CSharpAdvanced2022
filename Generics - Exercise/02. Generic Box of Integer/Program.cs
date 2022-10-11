using System;

namespace _02.BoxOfInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                box.Items.Add(number);
            }
            Console.WriteLine(box.ToString());

        }
    }
}
