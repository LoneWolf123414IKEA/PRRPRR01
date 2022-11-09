using System;
namespace tba
{
    class program
    {
        static void Main(string[] args)
        {
            string[] enemy = { "skeleton", "knight" };
            Random rand = new Random();
            int hp = 125;
            int res = 10;
            int dmg = 5;
            int ehp;
            int eres;
            int edmg;
            while (hp > 0)
            {
                switch (enemy[rand.Next(enemy.Length)])
                {
                    case "skeleton":
                        ehp = rand.Next(10, 21);
                        eres = rand.Next(5, 14);
                        edmg = rand.Next(5, 11);
                        while (ehp > 0)
                        {
                            Console.Clear();
                            Console.WriteLine($"Skeleton:\nHp: {ehp}\nRes: {eres}\nDmg: {edmg}-{edmg + 5}");
                            Console.WriteLine("1. attack\n2. defend\n3. run");
                            switch (Console.Read())
                            {
                                case 1:
                                    ehp -= rand.Next(dmg, dmg+5);
                                    break;                                                                                                               
                                case 2:
                                    break;
                                case 3:
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case "knight":
                        break ;
                    default:
                        break;

                }
            }
        }
    }
}