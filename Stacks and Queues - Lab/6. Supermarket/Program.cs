using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            Queue<string> queue = new Queue<string>();
            
            while (line != "End")
            {
                
                
                
                if (line == "Paid")
                {
                    while (queue.Count > 0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                     
                }
                else
                {
                    queue.Enqueue(line);    
                }
                line = Console.ReadLine();

            }
            Console.WriteLine(queue.Count + " people remaining.");
        }
    }
}
