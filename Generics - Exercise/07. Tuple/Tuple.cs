using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Tuple
{
    public class Tuple<T1, T2>
    {
        public T1 Item1;
        public T2 Item2;
        public Tuple()
        {
            Item1 = default(T1);
            Item2 = default(T2);
        }
        public override string ToString()
        {
            return $"{Item1} -> {Item2}";
        }
    }
}
