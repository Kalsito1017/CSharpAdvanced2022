﻿using System;
using System.Collections.Generic;

namespace Sets_and_Dictionaries_Advanced___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //random things
            //HashSet<string> set = new HashSet<string>();
            var dic = new Dictionary<string, int>();
            dic.Add("hehehah", 150);
            if (dic.ContainsValue(150))
            {
                Console.WriteLine(dic.ContainsValue(150));
            }
                
        }
    }
}
