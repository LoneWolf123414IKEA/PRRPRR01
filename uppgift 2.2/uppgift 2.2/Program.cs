using System;
namespace kap2upp2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What year is it?!");
            string yeartxt = Console.ReadLine();
            int year = int.Parse(yeartxt);
            Console.WriteLine("the year in 20 years will be " + (year+20));
        }
    }
}