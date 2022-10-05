using System.Data;
namespace Kap3Upp19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your calculation");
            var result = new DataTable().Compute(Console.ReadLine(), null);
            Console.WriteLine(result);
            for()
        }
    }
}