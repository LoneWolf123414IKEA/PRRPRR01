using System;

namespace kap5upp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] h = new int[rand.Next(100000)];
            Console.WriteLine(h.Length);
            for (int i = 0; i < h.Length; i++) h[i]=rand.Next(100);
            foreach (int i in h.Distinct().ToArray())
            {
                h.Count(i);
            }
           
        }
    }
}
