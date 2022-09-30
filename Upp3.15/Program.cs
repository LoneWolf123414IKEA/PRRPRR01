using System;
namespace kap3upp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How long do yo want to rent a car? (Please enter in full hours)");
            int renttime = int.Parse(Console.ReadLine());
            renttime *= 80;
            if (renttime < 950)
            {
                Console.WriteLine("you will pay " + renttime + " kr");
            }
            else
            {
                Console.WriteLine("Sorry but you have exeeded the max rent");
            }
        }
    }
}