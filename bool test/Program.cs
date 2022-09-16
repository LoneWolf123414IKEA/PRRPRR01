using System;
namespace Booltest
{
    class program
    {
        static void Main(string[] args)
        {
            string Crrawn;
            int pnt = 0;
            Console.WriteLine("welcome to this quiz");

            Crrawn = "B";
            Console.WriteLine("What is the capital of India?\nA:Bogota\nB:New Delhi\nC:Calcuta");
            if (Console.ReadLine().ToUpper() == Crrawn)
            {
                pnt += 1;
            }

            Crrawn = "A";
            switch (pnt)
            {
                case 0:
                    Console.WriteLine("What sort of creature is a cassowary?\nA:Bird\nB:Fish\nC:Crab");
                    break;
                case 1:
                    Console.WriteLine("How many surfaces does a Möbius strip have?\nA:1\nB:2\nC:3");
                    break;
                default:
                    break;
            }
            if (Console.ReadLine().ToUpper() == Crrawn)
            {
                pnt += 1;
            }

            Crrawn = "C";
            switch (pnt)
            {
                case 0:
                    Console.WriteLine("question?\nA:awnser\nB:awnser\nC:awnser");
                    break;
                case 1:
                    Console.WriteLine("question?\nA:awnser\nB:awnser\nC:awnser");
                    break;
                case 2:
                    Console.WriteLine("question?\nA:awnser\nB:awnser\nC:awnser");
                    break;
                default:
                    break;
            }
            if (Console.ReadLine().ToUpper() == Crrawn)
            {
                pnt += 1;
            }

            Crrawn = "A";
            switch (pnt)
            {
                case 0:
                    Console.WriteLine("question?\nA:awnser\nB:awnser\nC:awnser");
                    break;
                case 1:
                    Console.WriteLine("question?\nA:awnser\nB:awnser\nC:awnser");
                    break;
                case 2:
                    Console.WriteLine("question?\nA:awnser\nB:awnser\nC:awnser");
                    break;
                case 3:
                    Console.WriteLine("question?\nA:awnser\nB:awnser\nC:awnser");
                    break;
                default:
                    break;
            }
            if (Console.ReadLine().ToUpper() == Crrawn)
            {
                pnt += 1;
            }

            Console.WriteLine(pnt);
        }
    }
}