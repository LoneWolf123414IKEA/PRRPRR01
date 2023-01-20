using System;

namespace kap5upp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ctrys = {3123, 123, 5246 ,3656, 2466436};
            foreach (int ctry in ctrys)
            {
                foreach (char i in ctry.ToString())
                {
                    Console.Write(i);
                    Thread.Sleep(100);
                }
                Console.Write(" ");
                Thread.Sleep(400); 
            }
        }
    }
}
