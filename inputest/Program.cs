using System;
namespace passcode
{
    class Program
    {
        private static void Main(string[] args)
        {
            int attempts = 5;
            bool locked = true;
            while(locked)
            {
                Console.WriteLine("Input username:");
                var usn = Console.ReadLine();
                Console.WriteLine("input password:");
                var pss = Console.ReadLine();
                if (usn == "Lone" && pss == "PassW0rd" || usn == "IKEA" && pss == "Pyram1ds")
                {
                    Console.WriteLine("Welcome back Mx." + usn + "!");
                    locked = false;
                }
                else if (usn == "Pontus" && pss == "Eloo")
                {
                    Console.WriteLine("Welcome back Mr." + usn + "!");
                    locked = false;
                }
                else if (usn == "Freja" && pss == "Hiya")
                {
                    Console.WriteLine("Welcome back Ms." + usn + "!");
                    locked = false;
                }
                else if (attempts == 0)
                {
                    Console.WriteLine("Locking console, please restart.");
                    return;
                }
                else
                {
                    Console.WriteLine("incorrect username or password, you have " + attempts + " attempts left.");
                    attempts -= 1;
                }
                
            }
            Console.WriteLine("Access granted.");

        }
    }
}