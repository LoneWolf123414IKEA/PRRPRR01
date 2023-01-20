using System;

namespace kap5upp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"Samuel", "Freja", "Erik", "Lone", "IKEA"};
            Array.Sort(names);
            Console.WriteLine(names[0]);
        }
    }
}
