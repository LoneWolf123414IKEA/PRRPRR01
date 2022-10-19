using System;
using System.Reflection.Metadata.Ecma335;

namespace Upp23kap4
{
    class program
    {
        static void Main(string[] args)
        {
            string contin;
            List<int> nums = new List<int>();
            while(true)
            {
                Console.WriteLine("Write a number or write \"n\" if you want to print the biggest one");
                contin = Console.ReadLine();
                if (contin == "n")
                {
                    break;
                }
                else
                {
                    nums.Add(int.Parse(contin));
                }
            }
            nums.Sort();
            nums.Reverse();
            int[] numsa = nums.ToArray();
            Console.WriteLine(numsa[0]);
        }
    }
}