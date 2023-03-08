using System;
using System.Collections.Generic;
using TBA;
namespace TBA
{
    class Program
    {

        public static chr player = new chr();
        public static move move = new move();
        public static items inv = new items();
        static void Main()
        {
            Console.WriteLine("do you want to load a saved game? (y/n)");
            if (Console.ReadLine() == "y")
            {
                Console.WriteLine("input name of saved character");
                player.Chload(Console.ReadLine());
                inv.invgen(player.name);
                move.mapgen(player.name);
            }
            else
            {
                Console.Clear();
                Console.Write("I herby declare that i ");
                player.name = Console.ReadLine();
                if (File.Exists(player.name + ".save"))
                {
                    System.Environment.Exit(0);
                }
                Console.SetCursorPosition(23 + player.name.Length, 0);
                Console.WriteLine(" will serve the eternal guild with my soul untill i am released, i also am aware that if i shuld fall during the completion of a quest my mind and soul will be retured to the time and place i was issued that quest.");
                Console.Read();
                player.Chgen();
                inv.invgen("¦");
                move.mapgen("¦");
            }
            player.Chsave();
            move.mapsave(player.name);
            inv.invsave(player.name);

        }
    }
}