using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items = new T[0];
        }
      public void Add(T item)
        {
            T[] tempArray = items;
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
        }
    }
}
