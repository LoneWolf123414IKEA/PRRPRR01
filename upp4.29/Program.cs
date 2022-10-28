using System;
namespace upp29kap4
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("how long do you want your triangl: ");
            int length = int.Parse(Console.ReadLine());
            for (int i = 0; i <= length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}