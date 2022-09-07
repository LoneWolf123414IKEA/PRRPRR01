using System;
namespace kap2upp3
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How high can you jump in high jump? please awnser in meters.");
            string jumptxt = Console.ReadLine();
            float jump = float.Parse(jumptxt);
            Console.WriteLine("You can jump " + (2.45-jump) + " meters lower than the world record!");
    }
        }
}