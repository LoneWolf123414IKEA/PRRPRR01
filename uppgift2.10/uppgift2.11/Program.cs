using System;
namespace kap2upp11
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how long did Alma jump in metres?");
            float Almanum = float.Parse(Console.ReadLine());
            Console.WriteLine("how long did Elin jump in metres?");
            float Elinnum = float.Parse(Console.ReadLine());
            Console.WriteLine("Elin jumped " + (Elinnum - Almanum) + "m more than Alma.");
        }
    }
}