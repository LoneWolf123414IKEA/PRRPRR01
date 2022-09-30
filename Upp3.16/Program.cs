using System;
namespace kap3upp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the playtime(i.e how long it is) of your song, first minutes then seconds");
            int playtime = (int.Parse(Console.ReadLine()) * 60);
            playtime += int.Parse(Console.ReadLine());
            if (playtime >= 165 && playtime <= 260)
            {
                Console.WriteLine("We can play your song on air");
            }
            else
            {
                Console.WriteLine("Sorry but your song is not accaptable");
            }
        }
    }
}