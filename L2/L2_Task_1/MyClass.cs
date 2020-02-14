using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Task_1
{
    class MyList<T> : IMyList<T>
    {
        private T[] arrey = new T[] { };
        public T this[int index]
        {
            get { return arrey[index]; }
        }
        public int Count
        {
            get { return arrey.Length; }
        }
        public MyList()
        {
            T[] arrey;
        }
        public void Add(T a)
        {
            Array.Resize(ref arrey, arrey.Length +1);
            arrey[arrey.Length - 1] = a;
        }
        public void Clear()
        {
            Array.Resize(ref arrey, 0);
        }
        public bool Contains(T item)
        {
            if (Array.IndexOf(arrey, item) == -1)
                return false;
            else
                return true;
        }
    }
}
