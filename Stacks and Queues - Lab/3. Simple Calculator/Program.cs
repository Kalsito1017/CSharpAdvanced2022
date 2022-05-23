using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Stack<string> stack = new Stack<string>(input.Reverse());
            double result = 0;
            // 2 + 5 + 10 - 2 - 1
            while (stack.Count > 1)
            {
                string firstItem = stack.Pop();
                string symbolOperator = stack.Pop();
                string secondItem = stack.Pop();
                double firstNum = double.Parse(firstItem);
                double secondNum = double.Parse(secondItem);
                if (symbolOperator == "+")
                {
                    result = firstNum + secondNum;
                    stack.Push(result.ToString());
                }
                else if (symbolOperator == "-")
                {
                    result = firstNum - secondNum;
                    stack.Push(result.ToString());
                }
                
            }
            Console.WriteLine(result);
        }
    }
}
