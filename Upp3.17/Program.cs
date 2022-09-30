using System;
namespace kap3upp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number");
            int num = (int.Parse(Console.ReadLine()));
            Console.WriteLine("please enter the second number");
            int num2 = (int.Parse(Console.ReadLine()));
            Console.WriteLine("please choose which opperator you wish to use:\n1:Addition\n2:Subtraction\n3:Multiplication\n4:Division");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine(num + num2);
                    break;
                case "2":
                    Console.WriteLine(num - num2);
                    break;
                case "3":
                    Console.WriteLine(num * num2);
                    break;
                case "4":
                    Console.WriteLine(num / num2);
                    break;
                default:
                    break;
            }
        }
    }
}