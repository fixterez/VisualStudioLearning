using System;
using System.Collections.Generic;

namespace GenericsYapisi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            
            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("İstanbul");
        }
    }
    class MyList<T> // Generic Class
    {
        T[] _array;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {

        }
    }
}
