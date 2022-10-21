using System;
namespace kap4upp27
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "ayup";
            string lttr;
            int steps = int.Parse(Console.ReadLine());
            foreach (char i in text)
            {
                lttr = i.ToString();
                for (int j = 0; j < steps; j++)
                {
                    lttr = " " + lttr;
                }
                Console.WriteLine(lttr);
            }
        }
    }
}