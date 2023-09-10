using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingListT
{
    public interface  MyListT<T>
    {
        void Add(T value);
        void Remove(T value);
        bool Contains(T value);
        void RemoveAt(int index);

      
        int Count { get; }
        T this[int index] { get; set; }
    }
}
