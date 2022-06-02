using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "1")
                {
                    string currText = sb.ToString();
                    stack.Push(currText);
                    sb.Append(input[1]);
                }
                else if (input[0] == "2")
                {
                    string currText = sb.ToString();
                    int symbsToRemove = int.Parse(input[1]);
                    stack.Push(currText);
                    sb.Remove(sb.Length - symbsToRemove, symbsToRemove);
                }
                else if (input[0] == "3")
                {
                    string text = sb.ToString();
                    Console.WriteLine(text.ElementAt(int.Parse(input[1]) - 1));
                }
                else if (input[0] == "4")
                {
                    sb.Clear();
                    sb.Append(stack.Pop());
                }
            }
        }
    }
}
