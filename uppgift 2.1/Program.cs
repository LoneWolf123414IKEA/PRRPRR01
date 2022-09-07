using System;
namespace kap2upp1
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What city are you from?");
            string hometw = Console.ReadLine();
            Console.WriteLine("Where in the world would you most want to visit?");
            string destin = Console.ReadLine();
            Console.WriteLine("Hello " + hometw + "-inhabitant, I hope you get to go to " + destin);
        }
    }
}