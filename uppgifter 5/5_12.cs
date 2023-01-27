//dosent lock repeat numbers correctly

using System;

namespace kap5upp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] dice = new int[5];
            bool temp = false;
            bool[] win = {true, true, true, true, true};
            while (win[0] || win[1] || win[2] || win[3] || win[4])
            
            {
                for (int j = 0; j < win.Length; j++)
                {
                    if (win[j]) dice[j] = rand.Next(5);
                    Console.Write(dice[j] + " ");
                    Console.Write(win[j] + " ");
                }
                Console.Write("\nchoose wich to lock: ");
                foreach (string i in Console.ReadLine().Split(' '))
                {
                    for (int j = 0; j < dice.Length; j++)
                    {
                        if (!win[j] && dice[j] == int.Parse(i))
                        {
                            temp = true;
                            break;
                        }
                        else if (dice[j] == int.Parse(i))
                        {
                            win[j] = false;
                            break;
                        }
                    }
                    if (temp)
                    {
                        temp = false;
                        break;
                    }
                }
                
            }
            
        }
    }
}
