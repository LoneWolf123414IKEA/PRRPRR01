using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace tba
{
    class program
    {
        public static List<float> ItemStats(int id)
        {
            var list = new List<float>();
            /*else if (id == )
            {
                list.Add();
                list.Add();
            }*/
            if (id == 0)
            {
                list.Add(1);
                list.Add(10);
            }
            else if (id == 1)
            {
                list.Add(1);
                list.Add(11);
            }
            else if (id == 2)
            {
                list.Add(1);
                list.Add(4242);
            }
            else if (id == 4 || id == 15 || id == 16 || id == 17 || id == 18)
            {
                list.Add(2);
                list.Add(1);
            }
            else if (id == 5 || id == 6 || id == 7 || id == 8 || id == 9 || id == 10 || id == 11 || id == 12)
            {
                list.Add(2);
                list.Add(0.1F);
            }
            else if (id == 13)
            {
                list.Add(0);
                list.Add(1);
            }
            else if (id == 14)
            {
                list.Add(2);
                list.Add(10);
            }
            else
            {
                list.Add(0);
                list.Add(0);
            }
            return list;
        }
        static void Main(string[] args)
        {
            string[] enemy =
            {
                "skelly",
                "skelly",
                "skelly",
                "skelly",
                "skelly",
                "skelly",
                "skelly",
                "skelly",
                "skelly",
                "knight",
                "knight",
                "knight",
                "knight",
                "bbbg"
            };
            string[] items =
            {
                "wooden sword",
                "club",
                "Needle",
                "ancent sword",
                "small heal", 
                "smaller heal", 
                "smaller heal",
                "smaller heal", 
                "smaller heal", 
                "smaller heal", 
                "smaller heal", 
                "smaller heal", 
                "smaller heal", 
                "Medkit", 
                "Stimpack",
                "small heal",
                "small heal",
                "small heal",
                "small heal"
            };
            List<int> inv = new List<int>();
            inv.Add(2);
            int maxinv = 2;
            Random rand = new Random();
            float hp = 125;
            float res = 0.05F;
            int dmg = 5;
            float ehp = 100;
            float eres = 100;
            int edmg = 100;
            float tempdmg;
            float etempdmg;
            string opt;
            int temp;
            var templist = new List<float>();
            string name = "bbbe";
            while (hp > 0)
            {
                Console.Clear();
                Console.WriteLine("do you want too \"loot\" or \"kick door\"");
                if (Console.ReadLine() == "loot")
                {
                    temp = rand.Next(99);
                    if (temp < 40 && inv.Count() <= maxinv)
                    {
                        temp = rand.Next(items.Length);
                        Console.WriteLine("do you want " + items[temp] + "?");
                        if (Console.ReadLine() == "yes")
                        {
                            inv.Add(temp);
                        }
                    }
                    else if (temp < 40 && inv.Count() > maxinv)
                    {
                        temp = rand.Next(items.Length);
                        Console.WriteLine("do you want " + items[temp] + "?");
                        if (Console.ReadLine() == "yes")
                        {
                            for (int i = 0; i < inv.Count(); i++)
                            {
                                Console.WriteLine((i + 1) + " " + items[inv[i]]);
                            }
                            Console.WriteLine("\nchoose item to discard");
                            inv.RemoveAt(int.Parse(Console.ReadLine()) - 1);
                            inv.Add(temp);
                        }
                    }
                    else if (temp > 12)
                    {
                        res += rand.Next(1, 15) / 100;
                        Console.WriteLine("You found some armour");
                    }
                    else
                    {
                        Console.WriteLine("you found nothing");
                        Console.ReadKey();
                    }
                }
                switch (enemy[rand.Next(enemy.Length)])
                {
                    case "skelly":
                        name = "skeleton";
                        ehp = rand.Next(10, 21);
                        eres = rand.Next(5, 14) / 100;
                        edmg = rand.Next(5, 11);
                        break;
                    case "knight":
                        name = "knight";
                        ehp = rand.Next(23, 31);
                        eres = rand.Next(95, 100) / 100;
                        edmg = rand.Next(15, 20);
                        break;
                    default:
                        name = "Exocutioner";
                        ehp = 1260;
                        eres = 1.5F;
                        edmg = 20;
                        res -= 0.1F;
                        break;   
                }

                while (ehp > 0 && hp > 0)
                {
                    Console.Clear();
                    Console.WriteLine($"{name}:\nHp: {ehp}\nRes: {eres}\nDmg: {edmg}-{edmg + 5}\n\nPlayer:\nHp: {hp}\nRes: {res}\nDmg: {dmg}-{dmg + 5}\n");
                    Console.WriteLine("1. attack 2. item 3. run");
                    opt = Console.ReadLine();
                    tempdmg = 0;
                    Console.Clear();
                    switch (opt)
                    {
                        case "1":
                            Console.WriteLine();
                            if (rand.Next(100) < 88)
                            {
                                tempdmg = rand.Next(dmg, dmg + 5);
                            }
                            else
                            {
                                tempdmg = rand.Next(dmg, dmg + 5) * (1 - eres);
                                Console.WriteLine("Enemy resisted");
                            }
                            break;
                        case "2":
                            Console.WriteLine("choose item");
                            for (int i = 0; i < inv.Count(); i++)
                            {
                                Console.WriteLine((i) + " " + items[inv[i]]);
                            }
                            temp = int.Parse(Console.ReadLine());
                            templist = program.ItemStats(inv[temp]);
                            switch (templist[0])
                            {
                                case 0:
                                    switch (templist[1])
                                    {
                                        case 0:
                                            tempdmg = -20;
                                            eres += 1;
                                            break;
                                        case 1:
                                            res -= 0.1F;
                                            dmg -= 2;
                                            hp += 100;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 1:
                                    temp = (int)templist[1];
                                    tempdmg = rand.Next(temp, temp + 5);
                                    break;
                                case 2:
                                    hp += templist[1];
                                    break;
                                default:
                                    break;
                            }
                            templist.Clear();
                            break;
                        case "3":
                            res -= 0.5F;
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
                        etempdmg = rand.Next(edmg, edmg + 5) * (1 - res);
                        Console.WriteLine("You resisted");
                        res -= 0.01F;
                    }
                    Console.WriteLine($"You did {tempdmg} damage\nYou lost {etempdmg} health");
                    hp -= etempdmg;
                    ehp -= tempdmg;
                    Console.ReadKey();
                }
            }
        }
    }
}
