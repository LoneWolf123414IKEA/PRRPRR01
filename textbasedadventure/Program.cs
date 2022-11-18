using System;
namespace tba
{
    class program
    {
        static void Main(string[] args)
        {
            string[] enemy = 
            { 
                "skeleton", 
                "knight" 
            };
            string[] weapons = 
            { 
                "wooden sword",
                "club",
                "Needle",
                "ancent sword"
            };
            int[] weaponsdmg = 
            { 
                10, 
                11,
                4242,
                -10
            };
            string[] items = 
            { 
                "small heal", //0
                "smaller heal", //1
                "smaller heal", //2
                "smaller heal", //3
                "smaller heal", //4
                "smaller heal", //5
                "smaller heal", //6
                "smaller heal", //7
                "smaller heal", //8
                "Medkit", //9
                "Stimpack" //1
            };
            float[] itemssstt = 
            { 
                1, 
                0.1F, 
                0.1F, 
                0.1F, 
                0.2F, 
                0.1F, 
                0.01F, 
                0.1F, 
                0.1F,
                100,
                20
            };
            List<int> wepinv = new List<int>();
            wepinv.add(3);
            List<int> inv = new List<int>();
            int maxwep = 1;
            int maxinv = 2;
            Random rand = new Random();
            float hp = 125;
            float res = 0.05F;
            int dmg = 5;
            float ehp;
            float eres;
            int edmg;
            float tempdmg;
            float etempdmg;
            string opt;
            int temp;
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
                                Console.WriteLine((i+1) + " " + items[inv[i]]);
                            }
                            Console.WriteLine("\nchoose item to discard");
                            inv.RemoveAt(int.Parse(Console.ReadLine()) - 1);
                            inv.Add(temp);
                        }
                    }
                    else if (temp > 12 && wepinv.Count() <= maxwep)
                    {
                        temp = rand.Next(weapons.Length);
                        if (temp == 2)
                        {
                            temp = 3;
                        }
                        Console.WriteLine("do you want " + weapons[temp] + "?");
                        if (Console.ReadLine() == "yes")
                        {
                            wepinv.Add(temp);
                        }
                    }
                    else if (temp > 12 && wepinv.Count() > maxwep)
                    {
                        temp = rand.Next(weapons.Length);
                        if (temp == 2)
                        {
                            temp = 3;
                        }
                        Console.WriteLine("do you want " + weapons[temp] + "?");
                        if (Console.ReadLine() == "yes")
                        {
                            for (int i = 0; i < wepinv.Count(); i++)
                            {
                                Console.WriteLine((i + 1) + " " + weapons[wepinv[i]]);
                            }
                            Console.WriteLine("\nchoose item to discard");
                            wepinv.RemoveAt(int.Parse(Console.ReadLine()) - 1);
                            wepinv.Add(temp);
                        }
                    }
                    else if (temp > 40 && temp < 42)
                    {
                        res += rand.Next(1, 15)/100;
                        Console.WriteLine("You found some armour");
                    }
                    else
                    {
                        Console.WriteLine("you found nothing)");
                        Console.ReadKey();
                    }
                }
                switch (enemy[rand.Next(enemy.Length)])
                {
                    case "skeleton":
                        ehp = rand.Next(10, 21);
                        eres = rand.Next(5, 14) / 100;
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
                                    Console.WriteLine("1. attack\n2. heal");
                                    if (Console.ReadLine() == "1")
                                    {
                                        Console.WriteLine("choose weapon");
                                        for (int i = 0; i < wepinv.Count(); i++)
                                        {
                                            Console.WriteLine((i + 1) + " " + weapons[wepinv[i]]);
                                        }
                                        temp = int.Parse(Console.ReadLine()) - 1;
                                        tempdmg = rand.Next(weaponsdmg[temp], weaponsdmg[temp] + 5);
                                    }
                                    else
                                    {
                                        Console.WriteLine("choose heal");
                                        for (int i = 0; i < inv.Count(); i++)
                                        {
                                            Console.WriteLine((i + 1) + " " + items[inv[i]]);
                                        }
                                        temp = int.Parse(Console.ReadLine()) - 1;
                                        if (temp == 9)
                                        {
                                            res -= 0.1F;
                                            dmg -= 2;
                                        }
                                        hp += itemssstt[temp];
                                    }
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
                            }
                            Console.WriteLine($"You did {tempdmg} damage\nYou lost {etempdmg} health");
                            hp -= etempdmg;
                            ehp -= tempdmg;
                            Console.ReadKey();
                        }
                        break;
                    case "knight":
                        ehp = rand.Next(23, 31);
                        eres = rand.Next(95, 100) / 100;
                        edmg = rand.Next(15, 20);
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
                                    Console.WriteLine("1. attack\n2. heal");
                                    if (Console.ReadLine() == "1")
                                    {
                                        Console.WriteLine("choose weapon");
                                        for (int i = 0; i < wepinv.Count(); i++)
                                        {
                                            Console.WriteLine((i + 1) + " " + weapons[wepinv[i]]);
                                        }
                                        temp = int.Parse(Console.ReadLine()) - 1;
                                        tempdmg = rand.Next(weaponsdmg[temp], weaponsdmg[temp] + 5);
                                    }
                                    else
                                    {
                                        Console.WriteLine("choose heal");
                                        for (int i = 0; i < inv.Count(); i++)
                                        {
                                            Console.WriteLine((i + 1) + " " + items[inv[i]]);
                                        }
                                        temp = int.Parse(Console.ReadLine()) - 1;
                                        if (temp == 9)
                                        {
                                            res -= 0.1F;
                                            dmg -= 2;
                                        }
                                        hp += itemssstt[temp];
                                    }
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
                            }
                            Console.WriteLine($"You did {tempdmg} damage\nYou lost {etempdmg} health");
                            hp -= etempdmg;
                            ehp -= tempdmg;
                            Console.ReadKey();
                        break;
                    default:
                        break;

                }
            }
        }
    }
}
