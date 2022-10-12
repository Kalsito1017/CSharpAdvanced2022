using System;
using System.Linq;

namespace _01._ListyIterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ListyIterator<string> iterator = new ListyIterator<string>();
            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (cmdArgs[0] == "Create")
                {
                    iterator = new ListyIterator<string>(cmdArgs.Skip(1).ToArray());
                }
                else if (cmdArgs[0] == "Move")
                {
                    Console.WriteLine(iterator.Move());
                }
                else if (cmdArgs[0] == "HasNext")
                {
                    Console.WriteLine(iterator.HasNext());
                }
                else if (cmdArgs[0] == "Print") 
                {
                    iterator.Print();
                }
                else if (cmdArgs[0] == "PrintAll")
                {
                    foreach (var item in iterator)
                    {
                        Console.Write($"{item} ");
                    }
                    Console.WriteLine();
                }
                command = Console.ReadLine();
            }



        }
    }
}
