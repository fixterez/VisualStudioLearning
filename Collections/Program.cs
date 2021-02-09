using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Collections
            List<String> alphabets = new List<string> { "a", "b", "c", "d" };
            Console.WriteLine(alphabets[0]);
            Console.WriteLine(alphabets[1]);
            Console.WriteLine(alphabets[2]);
            Console.WriteLine(alphabets[3]);
            alphabets.Add("e");
            Console.WriteLine(alphabets[4]);
            Console.WriteLine(alphabets[4]);

        }
    }
}
