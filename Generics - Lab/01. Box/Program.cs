using System;
using System.Collections.Generic;

namespace BoxOfT
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();
            box.Add(1);
            box.Add(2);
            box.Add(3);
            Console.WriteLine(box.Remove());
            box.Add(4);
            box.Add(5);
            Console.WriteLine(box.Remove());
        }
    }
    public class Box <T>
    {
        public List<T> internalList = new List<T>();
        public void Add(T element)
        {
            internalList.Add(element);
        }
        int Count => internalList.Count;
        public T Remove()
        {
            var element = internalList[Count - 1];
            internalList.RemoveAt(Count - 1);
            return element;
        }
    }

}
