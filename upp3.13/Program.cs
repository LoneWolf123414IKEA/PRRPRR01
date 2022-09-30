using System;
namespace kap3upp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how old are you?");
            int age = int.Parse(Console.ReadLine());
            if (age < 16)
            {
                Console.WriteLine("you are too young to enter the competition");
            }
            else if (age > 19)
            {
                Console.WriteLine("you are too old to enter the competition");
            }
            else
            {
                Console.WriteLine("you may enter this competiton");
            }
        }
    }
}