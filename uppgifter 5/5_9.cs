using System;

namespace kap5upp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string?[] nams = new string[1000];
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("\ninput name: ");
                nams[i] = Console.ReadLine();
                Console.Write("do you want to input another name? (y/n) ");
                if (Console.ReadKey().Key != ConsoleKey.Y) break;
            }
            Console.Clear();
            Console.Write("input query: ");
            string? temp = Console.ReadLine();
            int cnt = 0;
            foreach (string n in nams)
            {
                if (temp == n) cnt++;
            }
            Console.WriteLine($"The name \"{temp}\" appears {cnt} times!");
        }
    }
}
