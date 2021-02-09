using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //Constructor
        public MyList()
        {
            items = new T[0];
        }
       public void Add(T item)
        {
            // Geçici Array
            T[] tempArray = items; //
            items = new T[items.Length+1];
            
            for (int i = 0; i < tempArray.Length; i++) // tempArray'de tutulan verileri geri almak.
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item; // eklenmek istenilen elemanı şu an ekleyebilirim.
        }
    }
}
