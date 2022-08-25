using System;
using System.Collections.Generic;

using System.Linq;
namespace _07._The_V_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Saffrona -> Following .Add(..)
            //Saffron -> followers .Add(...)
            var vlogger = new Dictionary<string, Dictionary<string, HashSet<string>>>();
            string input = Console.ReadLine();
            string following = "following";
            string followers = "followers";

            while (input != "Statistics")
            {
                //EmilConrad joined The V-Logger
                //VenomTheDoctor joined The V-Logger
                string[] inputArgs = input.Split();
                string action = inputArgs[1];
                string user = inputArgs[0];
                string starUser = inputArgs[2];
                if (action == "joined" && !vlogger.ContainsKey(user))
                {
                    vlogger.Add(user,new Dictionary<string, HashSet<string>>());
                    vlogger[user].Add(following, new HashSet<string>());
                    vlogger[user].Add(followers, new HashSet<string>());

                }

                input = Console.ReadLine();
            }
        }
    }
}
