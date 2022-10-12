using System;
using System.Linq;

namespace _03._Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListyIterator<string> list = new ListyIterator<string>();
            string command = Console.ReadLine();
            while (command != "END")
            {
                if (command.StartsWith("Push"))
                {
                    list.Push(command.Split(" ", StringSplitOptions.RemoveEmptyEntries).Skip(1).Select(p => p.Split(',').First()).ToArray());
                }
                else if (command.StartsWith("Pop"))
                {
                    try
                    {
                        list.Pop();
                    }
                    catch(ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                command = Console.ReadLine();
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
