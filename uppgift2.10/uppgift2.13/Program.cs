using System;
namespace kap2upp13
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the three wages and press endter inbetween.");
            int wagetot = int.Parse(Console.ReadLine());
            wagetot = wagetot + int.Parse(Console.ReadLine());
            wagetot = wagetot + int.Parse(Console.ReadLine());
            Console.WriteLine("Paying your employees will cost " + wagetot + "kr");
        }
    }
}