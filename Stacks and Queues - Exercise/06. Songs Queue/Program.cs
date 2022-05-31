using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(", ");

            string input = Console.ReadLine();

            Queue<string> queue = new Queue<string>(array);
            while (queue.Count > 0)
            {
                string[] placeHolders = input.Split();
                string command = placeHolders[0];

                if (command == "Play")
                {
                    queue.Dequeue();
                }
                else if (command == "Add")
                {
                    string song = input.Substring(4);
                    if (queue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(song);
                    }

                }
                else if (command == "Show" && queue.Count > 0)
                {
                    Console.WriteLine(string.Join(", ", queue));
                }


                input = Console.ReadLine();
            }

            Console.WriteLine("No more songs!");
        }
    }
}
