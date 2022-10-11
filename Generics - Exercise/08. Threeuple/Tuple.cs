using System;
using System.Collections.Generic;
using System.Text;

namespace _08._Threeuple
{
    public class TheeTuple<T1, T2, T3>
    {
        public T1 Item1;
        public T2 Item2;
        public T3 Item3;
        public TheeTuple()
        {
            Item1 = default(T1);
            Item2 = default(T2);
            Item3 = default(T3);
        }
        public override string ToString()
        {
            return $"{Item1} -> {Item2} -> {Item3}";
        }
    }
}
