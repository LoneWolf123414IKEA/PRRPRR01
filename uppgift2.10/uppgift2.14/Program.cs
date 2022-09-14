using System;
using System.Data;

namespace kap2upp14
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the three wages and press endter inbetween.");
            string math = Console.ReadLine();
            float inexmult = math.IndexOf("*");
            float first = float.Parse(math[..inexmult]);
            float second = float.Parse(math[(inexmult+1)..]);


            Console.WriteLine(first*second);
        }
    }
}