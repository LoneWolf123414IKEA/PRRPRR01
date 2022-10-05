using System;
namespace kap3upp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please write your first and last name");
            string[] nameli = Console.ReadLine().Split(" ");
            Array.Sort(nameli);
            Console.WriteLine(nameli[0] + " comes before " + nameli[1] + " alphabetically");
        }
    }
}