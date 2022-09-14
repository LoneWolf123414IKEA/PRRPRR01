using System;
namespace kap2upp12
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many days do you plan on using the car?");
            int days = int.Parse(Console.ReadLine());
            Console.WriteLine("how long do you plan on driving? Please round to the closest km.");
            int dist = int.Parse(Console.ReadLine());
            Console.WriteLine("your planned car renting will cost " + (300+(days-1)*500+dist) + "kr.");
        }
    }
}