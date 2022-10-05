using System;
namespace Kap3Upp20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your three words");
            string[] words = { Console.ReadLine(), Console.ReadLine(), Console.ReadLine() };
            Array.Sort(words);
            Console.WriteLine(words[0] + " " + words[1] + " " + words[2]);
        }
    }
}