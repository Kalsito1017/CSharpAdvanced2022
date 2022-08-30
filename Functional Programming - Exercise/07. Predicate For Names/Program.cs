using System;
using System.Linq;

namespace _07._Predicate_For_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // you can use both 
            Func<string, int, bool> nameLenght = (name
                , lenght) => name.Length <= lenght;
            int maxLenghtname = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(" ").Where(x => nameLenght(x, maxLenghtname)).ToArray();
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            
            //int num = int.Parse(Console.ReadLine());
            //string[] names = Console.ReadLine().Split(" ");
            //foreach (string name in names)
            //{
            //    if (name.Length <= num)
            //    {
            //        Console.WriteLine(name);
            //    }
            //}
            
        }
    }
}
