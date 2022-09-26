using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace _01._Blacksmith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var steelInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var carbonInput = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var steel = new Queue<int>(steelInput);
            var carbon = new Stack<int>(carbonInput);
            var swords = new Dictionary<string, int[]>
            {
                {"Gladius", new int[2]{70,0}},
                {"Shamshir", new int[2]{80,0}},
                {"Katana", new int[2]{90,0}},
                {"Sabre", new int[2]{110,0}},
                {"Broadsword", new int[2]{150,0}},
            };
            int counter = 0;
            while (steel.Count > 0 && carbon.Count > 0)
            {
                var currCarbon = carbon.Peek();
                var currSteel = steel.Peek();
                bool isMade = false;
                foreach (var sword in swords)
                {
                    if (currSteel + currCarbon == sword.Value[0])
                    {
                        sword.Value[1]++;
                        
                        carbon.Pop();
                        counter++;
                        isMade = true;
                        break;
                    }
                }
                steel.Dequeue();
                if (isMade)

                {
                    continue;
                }
                currCarbon += 5;
                carbon.Pop();
                carbon.Push(currCarbon);
            }
            Console.WriteLine(counter > 0
                ? $"You have forged {counter} swords." 
                 : "You did not have enough resources to forge a sword.");
            Console.WriteLine(steel.Count > 0 ? $"Steel left: {string.Join(", ", steel)}" : "Steel left: none");

            Console.WriteLine(carbon.Count > 0 ? $"Carbon left: {string.Join(", ", carbon)}" : "Carbon left: none");

            foreach (var sword in swords.Where(sword => sword.Value[1] > 0).OrderBy(sword => sword.Key))
            {
                Console.WriteLine($"{sword.Key}: {sword.Value[1]}");
            }



        }
    }
}
