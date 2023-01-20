using System;

namespace kap5upp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ctrys = { "1. china", "2. India", "3. USA", "4. Indonesia", "5. Pakistan"};
            foreach (string ctry in ctrys) Console.WriteLine(ctry);
            string[] nums = Console.ReadLine().Split(' ');
            foreach (string str in nums) Console.WriteLine(ctrys[int.Parse(str) - 1]);
        }
    }
}
