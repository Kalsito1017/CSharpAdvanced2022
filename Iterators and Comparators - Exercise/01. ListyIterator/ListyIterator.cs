using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _01._ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        public int Index = 0;
        public T[] array;
        public List<T> list;
        public ListyIterator(params T[] arr)
        {
            
            this.list = new List<T>(arr);
            this.Index = 0;
        }
        public bool Move()
        {
            if (HasNext())
            {
                Index++;
                return true;
            }
            return false;
        }
        public bool HasNext() => Index < list.Count - 1;
        public void Print() => Console.WriteLine(list.Count == 0 ? "Invalid Operation!" : list[Index].ToString());

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in list)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
