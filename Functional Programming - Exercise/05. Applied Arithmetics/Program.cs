using System;
using System.Collections.Generic;
using System.Linq;
namespace _05._Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<int[]> add = numberss =>
            {
                for (int i = 0; i < numberss.Length; i++)
                {
                    numberss[i] += 1;
                }
                
            };
            Action<int[]> subtract = numberss =>
            {
                for (int i = 0; i < numberss.Length; i++)
                {
                    numberss[i] -= 1;
                }
               
            };
            Action<int[]> multiply = numberss =>
            {
                for (int i = 0; i < numberss.Length; i++)
                {
                    numberss[i] *= 2;
                }
            };
            Action<int[]> PrintNumbers = numbers => Console.WriteLine(String.Join(" ", numbers));


            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            string comand = Console.ReadLine();
            List<int> list = new List<int>();
            while (true)
            {
                comand = Console.ReadLine();
                if (comand == "end")
                {
                    break;
                }
                
                if (comand == "add")
                {
                    
                     add(numbers);
                    
                }
                else if(comand == "multiply")
                {
                    
                     multiply(numbers);
                    

                }
                else if (comand == "subtract")
                {
                   
                        subtract(numbers);
                    
                }
                else if (comand == "print")
                {
                    PrintNumbers(numbers);
                }
            }
        }
    }
}
