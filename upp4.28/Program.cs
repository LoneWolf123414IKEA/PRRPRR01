using System;
namespace kap4upp28
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "ab";
            string expl = Console.ReadLine();
            bool a = false;
            bool b = false;
            foreach(char i in test)
            {
                foreach (char c in expl)
                {
                    if (i == c && i == 'a')
                    {
                        a = true;
                        break;
                    }
                    else if (i == c)
                    {
                        b = true;
                        break;
                    }
                }
                if (a && b)
                {
                    Console.WriteLine("both a and b are inn the text");
                }
            }
        }
    }
}