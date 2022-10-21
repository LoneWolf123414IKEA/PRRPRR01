using System.Data;
namespace Kap3Upp19
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            List<string> newnum = new List<string>();
            foreach (char i in number)
            {
                switch (i)
                {
                    case '0':
                        newnum.Add("1");
                        break;
                    case '1':
                        newnum.Add("2");
                        break;
                    case '2':
                        newnum.Add("3");
                        break;
                    case '3':
                        newnum.Add("4");
                        break;
                    case '4':
                        newnum.Add("5");
                        break;
                    case '5':
                        newnum.Add("6");
                        break;
                    case '6':
                        newnum.Add("7");
                        break;
                    case '7':
                        newnum.Add("8");
                        break;
                    case '8':
                        newnum.Add("9");
                        break;
                    default:
                        newnum.Add("0");
                        break;
                }
            }
        Console.WriteLine(string.Join("", newnum));
        }
    }
}