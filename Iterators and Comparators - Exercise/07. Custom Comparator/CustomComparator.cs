using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _07._Custom_Comparator
{
    public class CustomComparator : IComparer<int>
    {
       public int[] Array { get; set; }
        public CustomComparator(int[] array)
        {
            Array = array;
        }
        public int Compare(int x, int y)
        {
            if (x % 2 == 0 && y % 2 != 0)
            {
                return -1;
            }
            if (x % 2 != 0 && y % 2 == 0)
            {
                return 1;
            }
            else
            {
                return x.CompareTo(y);
            }
        }
    }
}
