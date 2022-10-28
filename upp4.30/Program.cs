using System;
namespace Kap4Upp30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("how many X per group: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("how many O per group: ");
            int o = int.Parse(Console.ReadLine());
            Console.Write("how many O groups: ");
            int groups = int.Parse(Console.ReadLine());
            Console.Write("how many rows: ");
            int rows = int.Parse(Console.ReadLine());
            string xw = "x";
            string ow = "o";
            for (int i = 0; i < x; i++)
            {
                xw += "x";
            }
            for (int i = 0; i < o; i++)
            {
                ow += "o";
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < groups; j++)
                {
                    Console.Write(xw + "-" + ow + "-");
                }
                Console.WriteLine(xw);
            }
        }
    }
}