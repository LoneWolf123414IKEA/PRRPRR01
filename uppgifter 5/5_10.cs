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
            for (int i = 0; i < h.Length; i++) h[i] = rand.Next(100);
            Array.Sort(h);
            int temp = 0;
            int stor = 0;
            List<int> scor = new List<int>();
            foreach (int i in h.Distinct().ToArray())
            {
                foreach (int j in h)
                {
                    if (j == i) temp++;
                }
                if (temp == stor) scor.Add(i);
                else if (temp > stor)
                {
                    stor = temp;
                    scor.Clear();
                    scor.Add(i);
                }
                temp = 0;
            }
            scor.ToArray();
            Console.Write("the most common numbers are: ");
            foreach (int i in scor) Console.Write(i + " ");
        }
    }
}
