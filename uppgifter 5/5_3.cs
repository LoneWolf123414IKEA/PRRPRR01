using System;

namespace kap5upp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] qna = { { "question", "question2", "question3", "question4" }, { "awns", "awns2", "awns3", "awns4" } };
            Console.WriteLine("input a number between 1 and 4");
            int cho = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("your question is:\n" + qna[0, cho] + "\nPlease awnser:");
            while(Console.ReadLine() != qna[1, cho]) Console.WriteLine("try again");
            Console.WriteLine("correct");
        }
    }
}
