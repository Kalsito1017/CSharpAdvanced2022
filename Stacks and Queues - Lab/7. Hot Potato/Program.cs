using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Lucas Jacob Noah Logan Ethan
            //10
            //input
            var firstLine = Console.ReadLine();
            string[] names = firstLine.Split(' ');
            int everyNth = int.Parse(Console.ReadLine());
            Queue<string> kids = new Queue<string>();
            foreach (var name in names)
            {
                kids.Enqueue(name);
            }
            while (kids.Count > 1)
            {
                for (int i = 0; i < everyNth - 1; i++)
                {
                    var potatoKid = kids.Dequeue();
                    kids.Enqueue(potatoKid); 
                }
                var kidToRemove = kids.Dequeue();
                Console.WriteLine("Removed " + kidToRemove);
            }
            Console.WriteLine("Last is " + kids.Dequeue()); 

        }

    }
}
