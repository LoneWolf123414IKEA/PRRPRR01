using System;
namespace Upp24Kap4
{
    class program
    {
        static void Main(string[] args)
        {
            bool dubblbreak = true;
            while (dubblbreak)
            {
                Console.WriteLine("Choose betweeen theese options:\n1. Subtract a number from another\n2. Divide a nnumber by another\n3. Exit the program"); 
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine(int.Parse(Console.ReadLine()) - int.Parse(Console.ReadLine()));
                        break;
                    case "2":
                        Console.WriteLine(int.Parse(Console.ReadLine()) / int.Parse(Console.ReadLine()));
                        break;
                    default:
                        dubblbreak = false;
                        break;
                }
            }
        }
    }
}
