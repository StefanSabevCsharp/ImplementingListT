using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingListT
{
    public class MyList : MyListT<int>

    {
        private int[] array = new int[4];
        public MyList()
        {
            array = new int[4];
        }
        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }

        public int Count { get; private set; }

        public void Add(int value)
        {
            Grow();
            array[Count] = value;

            Count++;
        }

        public bool Contains(int value)
        {
            for (int i = 0; i < Count; i++)
            {
                if (array[i] == value)
                {
                    return true;
                }
            }
            return false;
        }

        public void Remove(int value)
        {
            for(int i = 0; i < Count; i++)
            {
                if (array[i] == value)
                {
                    RemoveAt(i);
                    return;
                }
            }
            
        }

        public void RemoveAt(int index)
        {
            CheckIndex(index);
            for (int i = index; i < Count - 1; i++)
            {
                array[i] = array[i + 1];
            }
            Count--;
            Shrink();
        }
        private void Grow()
        {
            if (array.Length == Count)
            {
                int[] newArray = new int[array.Length * 2];
                Array.Copy(array, newArray, array.Length);
                array = newArray;
            }
        }
        private void CheckIndex(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException();
            }
        }
        private void Shrink()
        {
              if (array.Length == Count * 4)
            {
                int[] newArray = new int[array.Length / 2];
                Array.Copy(array, newArray, array.Length);
                array = newArray;
            }
        }
    }
}
