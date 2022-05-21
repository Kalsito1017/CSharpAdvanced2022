using System;
using System.Collections.Generic;

namespace _1_Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();
            // I Love C#
            Stack<char> stack = new Stack<char>();
            foreach (var ch in input)
            {
                stack.Push(ch);
            }
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }

            
        }
    }
}
