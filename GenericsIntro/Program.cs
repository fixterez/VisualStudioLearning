using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> alphabets = new MyList<string>();
            alphabets.Add("A");
        }
    }
}
