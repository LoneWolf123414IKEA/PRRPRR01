using System;
namespace tba
{
    class program
    {
        static void Main(string[] args)
        {
            string[] enemy = { "skeleton", "knight" };
            var[] weapons = {"wooden sword", 1, "club", 2};
            var[] weapons = {"small heal", 1, "smaller heal", 0.1};
            List<int> wepinv = new List<int>();
            List<int> inv = new List<int>();
            int maxwep = 3;
            int maxinv = 6;
            Random rand = new Random();
            float hp = 125;
            float res = 0.1;
            int dmg = 5;
            float ehp;
            float eres;
            int edmg;
            int tempdmg;
            int etempdmg;
            string opt;
            while (hp > 0)
            {
                switch (enemy[rand.Next(enemy.Length)])
                {
                    case "skeleton":
                        ehp = rand.Next(10, 21);
                        eres = rand.Next(5, 14)/100;
                        edmg = rand.Next(5, 11);
                        while (ehp > 0 && hp > 0)
                        {
                            Console.Clear();
                            Console.WriteLine($"Skeleton:\nHp: {ehp}\nRes: {eres}\nDmg: {edmg}-{edmg + 5}\n\nPlayer:\nHp: {hp}\nRes: {res}\nDmg: {dmg}-{dmg + 5}\n");
                            Console.WriteLine("1. attack 2. item 3. run");
                            opt = Console.ReadLine();
                            tempdmg = 0;
                            Console.Clear();
                            switch (opt)
                            {
                                case "1":
                                    if (rand.Next(100) < 88)
                                    {
                                        tempdmg = rand.Next(dmg, dmg + 5);
                                    }
                                    else
                                    {
                                        tempdmg = rand.Next(dmg, dmg + 5)*(1-eres);
                                        Console.WriteLine("Enemy resisted");
                                    }
                                    break;
                                case "2":
                                    break;
                                case "3":
                                    break;
                                default:
                                    break;
                            }
                            if (rand.Next(100) < 88)
                            {
                                etempdmg = rand.Next(edmg, edmg + 5);
                            }
                            else
                            {
                                etempdmg = rand.Next(edmg, edmg + 5)*(1-res);
                                Console.WriteLine("You resisted");
                            }
                            Console.WriteLine($"You did {tempdmg} damage\nYou lost {etempdmg} health");
                            hp -= etempdmg;
                            ehp -= tempdmg;
                            Console.ReadKey();
                        }
                        break;
                    case "knight":
                        break;
                    default:
                        break;
     
                }
            }
        }
    }
}
