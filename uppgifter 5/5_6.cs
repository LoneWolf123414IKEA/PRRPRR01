using System;

namespace kap5upp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split('*');
            long num = 1;
            foreach (string s in nums) num *= int.Parse(s);
            Console.WriteLine(num);
        }
    }
}
