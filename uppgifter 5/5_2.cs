using System;
namespace kap5upp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please first input the amount of numbers you want to enter, then input that amount of whole numbers:");
            string[] sentinces = new string[int.Parse(Console.ReadLine())];
            for (int i = 0; i < sentinces.Length; i++) sentinces[i] = "#" + (i + 1) + ": " + Console.ReadLine();
            Console.WriteLine("\nHere are your numbers numberd:");
            foreach (string i in sentinces) Console.WriteLine(i);
        }
    }
}
