using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //II.	Working with Queues
            //11 13 18 95 2 112 81 46


            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> numbers = new Queue<int>(arr);
            while (numbers.Count > 0)
            {
                if (numbers.Count == 1)
                {
                    Console.WriteLine(numbers.Dequeue());
                }
                else
                {
                    if (numbers.Peek() % 2 == 0)
                    {
                        Console.Write(numbers.Dequeue() + ", ");
                    }
                    else
                    {
                        numbers.Dequeue();
                    }
                }
            }
            
            
        }
    }
}
