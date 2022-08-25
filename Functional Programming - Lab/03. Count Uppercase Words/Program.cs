using System;
using System.Linq;
namespace _03._Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Func<string, bool> checker = word => char.IsUpper(word[0]);

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(w => checker(w)).ToArray();

            Console.WriteLine(string.Join("\n", input));

        }
       
        
    }
}
