using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Task_1
{
    interface IMyList<T>
    {
        void Add(T a);
       // T this[int index] { get; }
        int Count { get; }
        void Clear();
        bool Contains(T item);

    }
}
