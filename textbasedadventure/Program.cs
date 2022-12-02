using System;
using System.Collections;
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
            switch (id) {
                case 0:
                    list.Add(1);
                    list.Add(10);
                    break;
                case 1:
                    list.Add(1);
                    list.Add(11);
                    break;
                case 2:
                    if(Console.ReadLine() == "Dev, #0000")
                    {
                        list.Add(1);
                        list.Add(4242);
                    }
                    else
                    {
                        list.Add(0);
                        list.Add(0);
                    }
                    break;
                case 4:
                case 15:
                case 16:
                case 17:
                case 18:
                    list.Add(2);
                    list.Add(1);
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                    list.Add(2);
                    list.Add(0.1F);
                    break;
                case 13:
                    list.Add(0);
                    list.Add(1);
                    break;
                case 14:
                    list.Add(2);
                    list.Add(10);
                    break;
                default:
                    list.Add(0);
                    list.Add(0);
                break;
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
                "knight"
            };
            string[] bosses =
            {
                "executioner"
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
            string name = "knight";
            int xp = 0;
            int next = 1000;
            int kills = 0;
            while (hp > 0)
            {
                Console.Clear();
                Console.WriteLine("do you want too \"loot\", see your \"stats\", or \"kick door\"");
                opt = Console.ReadLine();
                if (opt == "loot")
                {
                    temp = rand.Next(99);
                    if (xp > next)
                    {
                        maxinv++;
                        Console.WriteLine("you found a small backpack!");
                        next += 1000;
                    }
                    else if (temp < 40 && inv.Count() <= maxinv)
                    {
                        temp = rand.Next(items.Length);
                        Console.WriteLine("do you want " + items[temp] + "?");
                        if (Console.ReadLine() == "yes" && temp != 2)
                        {
                            inv.Add(temp);
                        }
                        else
                        {
                            inv.Add(3);
                        }
                    }
                    else if (temp < 40 && inv.Count() > maxinv)
                    {
                        temp = rand.Next(items.Length);
                        Console.WriteLine("do you want " + items[temp] + "?");
                        if (Console.ReadLine() == "yes" && temp != 2)
                        {
                            for (int i = 0; i < inv.Count(); i++)
                            {
                                Console.WriteLine((i + 1) + " " + items[inv[i]]);
                            }
                            Console.WriteLine("\nchoose item to discard");
                            try
                            {
                                inv.RemoveAt(int.Parse(Console.ReadLine()) - 1);
                            }
                            catch
                            {
                                Console.WriteLine("out of range, removing first object");
                                inv.RemoveAt(0);
                            }
                            inv.Add(temp);
                        }
                        else
                        {
                            inv.RemoveAt(0);
                            inv.Add(3);
                        }
                    }
                    else if (temp < 52)
                    {
                        res += rand.Next(0, xp) / 100;
                        Console.WriteLine("You found some armour");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("you found nothing");
                        Console.ReadKey();
                    }
                }
                else if (opt == "stats")
                {
                    Console.Clear();
                    Console.WriteLine($"player:\nHp: {hp}\nResistance: {res * 100}%\nbase damage: {dmg}-{dmg + 5}\nLvL: {xp / 1000 + 1} Xp: {xp}\nKills: {kills}\nInventory size: {maxinv + 1}\n\n");
                    Console.WriteLine("inventory:");
                    for (int i = 0; i < inv.Count(); i++)
                    {
                        Console.WriteLine((i) + " " + items[inv[i]]);
                    }
                    Console.ReadKey();
                }
                if (xp > next)
                {
                    next += 1000;
                    switch (bosses[rand.Next(bosses.Length)])
                    {
                        case "executioner":
                            name = "Exocutioner";
                            ehp = 1260;
                            eres = 1.5F;
                            edmg = 20;
                            res -= 0.1F;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
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
                            break;
                    }
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
                            try
                            {
                                temp = int.Parse(Console.ReadLine());
                                templist = program.ItemStats(inv[temp]);
                            }
                            catch
                            {
                                Console.WriteLine("out of range, defaulting to standard weapon");
                                templist = new List<float> {0, 0};
                                temp = 0;
                            }
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
                                            inv.RemoveAt(temp);
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
                                    inv.RemoveAt(temp);
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
                    if (ehp <= 0)
                    {
                        xp += rand.Next(10);
                        kills++;
                    }
                }
            }
        }
    }
}
