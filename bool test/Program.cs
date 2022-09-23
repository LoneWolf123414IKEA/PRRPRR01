using System;
namespace Booltest
{
    class Program
    {
        static void Main(string[] args)
        {
            int pnt = 0;
            Console.WriteLine("welcome to this quiz\nThe consept is quite simple, type the letter of the correct awnser and gain a point.\nDepending on how you do the difficulty will be adjusted during the course of the quiz!");

            Console.WriteLine("\nWhat is the capital of India?\nA:Bogota\nB:New Delhi\nC:Calcuta");
            if (Console.ReadLine()?.ToUpper() == "B")
            {
                pnt += 1;
            }

            switch (pnt)
            {
                case 0:
                    Console.WriteLine("\nWhat sort of creature is a cassowary?\nA:Bird\nB:Fish\nC:Crab");
                    break;
                case 1:
                    Console.WriteLine("\nHow many surfaces does a Möbius strip have?\nA:1\nB:2\nC:3");
                    break;
                default:
                    break;
            }
            if (Console.ReadLine()?.ToUpper() == "A")
            {
                pnt += 1;
            }

            switch (pnt)
            {
                case 0:
                    Console.WriteLine("\nWhere did the Vietnam war take place?\nA:Hong-Kong\nB:Viet-Naam\nC:None of the above");
                    break;
                case 1:
                    Console.WriteLine("\nWhere did the Vietnam war take place?\nA:North Borneo\nB:The East Indies\nC:French Indo-China");
                    break;
                case 2:
                    Console.WriteLine("\nquestion?\nA:awnser\nB:awnser\nC:awnser");
                    break;
                default:
                    break;
            }
            if (Console.ReadLine()?.ToUpper() == "C")
            {
                pnt += 1;
            }

            switch (pnt)
            {
                case 0:
                    Console.WriteLine("\nquestion?\nA:awnser\nB:awnser\nC:awnser");
                    break;
                case 1:
                    Console.WriteLine("\nWho wrote the hit album \"Born in the U.S.A.\"?\nA:Bruce Springsteen\nB:Black sabbath\nC:Green Day");
                    break;
                case 2:
                    Console.WriteLine("\nquestion?\nA:awnser\nB:awnser\nC:awnser");
                    break;
                case 3:
                    Console.WriteLine("\nquestion?\nA:awnser\nB:awnser\nC:awnser");
                    break;
                default:
                    break;
            }
            if (Console.ReadLine()?.ToUpper() == "A")
            {
                pnt += 1;
            }

            Console.WriteLine("\nyou have gatherd together " + pnt + " points!"); 
        }
    }
}