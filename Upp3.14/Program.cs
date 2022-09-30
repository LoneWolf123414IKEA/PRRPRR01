using System;
namespace kap3upp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Have you graduated from highschool?(Y/N)");
            bool yn = Console.ReadLine() == "Y";
            Console.WriteLine("How old are you?");
            if (yn && int.Parse(Console.ReadLine()) >= 22)
            {
                Console.WriteLine("We would like to hire you");
            }
            else 
            {
                Console.WriteLine("Sorry but you do not fit our current requirements"); 
            }
        }
    }
}