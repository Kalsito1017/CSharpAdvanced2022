using System;
using System.Collections.Generic;
using System.Linq;
namespace _07._The_V_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, HashSet<string>>> vloggers =
                new Dictionary<string, Dictionary<string, HashSet<string>>>();

            string input;
            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] cmdInfo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string vloggerName = cmdInfo[0];
                string cmdType = cmdInfo[1];

                if (cmdType == "joined")
                {
                    if (vloggers.ContainsKey(vloggerName))
                    {
                        continue;
                    }
                    else if (!vloggers.ContainsKey(vloggerName))
                    {
                        vloggers.Add(vloggerName, new Dictionary<string, HashSet<string>>());
                    }
                    vloggers[vloggerName].Add("follow", new HashSet<string>());
                    vloggers[vloggerName].Add("followedBy", new HashSet<string>());
                }
                else if (cmdType == "followed")
                {
                    string vloggerNameFollowed = cmdInfo[2];

                    if (!vloggers.ContainsKey(vloggerName)
                        || !vloggers.ContainsKey(vloggerNameFollowed)
                        || vloggerName == vloggerNameFollowed)
                    {
                        continue;
                    }

                    vloggers[vloggerName]["follow"].Add(vloggerNameFollowed);
                    vloggers[vloggerNameFollowed]["followedBy"].Add(vloggerName);
                }
            }

            Console.WriteLine($"The V-Logger has a total of {vloggers.Keys.Count} vloggers in its logs.");

            int count = 0;
            foreach (var (vlogger, follows) in vloggers
                         .OrderByDescending(f => f.Value["followedBy"].Count)
                         .ThenBy(f => f.Value["follow"].Count))
            {
                count++;
                Console.WriteLine($"{count}. {vlogger} : {follows["followedBy"].Count} followers, {follows["follow"].Count} following");

                if (count == 1)
                {
                    foreach (string follower in follows["followedBy"].OrderBy(f => f))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
            }
        }
    }
}
