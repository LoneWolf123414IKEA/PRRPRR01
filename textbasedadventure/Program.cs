using System;
using System.ComponentModel;
using System.Threading;

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
            switch (id)
            {
                case 0:
                    list.Add(1);
                    list.Add(10);
                    break;
                case 1:
                    list.Add(1);
                    list.Add(11);
                    break;
                case 2:
                    if (Console.ReadLine() == "Dev, #0000")
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
        public static void PrintLine(string text)
        {
            foreach (char i in text)
            {
                Console.Write(i);
                Thread.Sleep(10);
            }
            Console.Write("\n");
        }
        public static void Print(string text)
        {
            foreach (char i in text)
            {
                Console.Write(i);
                Thread.Sleep(10);
            }
        }
        static void Main(string[] args)
        {
            int?[,] map = new int?[260, 260];
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
            float ehp = 0;
            float eres = 0;
            int edmg = 0;
            float tempdmg;
            float etempdmg;
            string opt;
            int temp;
            var templist = new List<float>();
            string name = "";
            int xp = 0;
            int next = 1000;
            int kills = 0;
            int bsslvl = 0;
            bool win = false;

            map[0, 0] = 1;
            map[255, 1] = -1;
            map[20, 34] = -2;
            map[200, 43] = -3;
            map[32, 150] = -4;
            map[2, 21] = -5;


            for (int y1 = 0; y1 < 260; y1++)
            {
                for (int x1 = 0; x1 < 260; x1++)
                {
                    if (map[y1, x1] == null)
                    {
                        map[x1, y1] = rand.Next(0, 4);
                    }
                }
            }
            int y = 0;
            int x = 0;
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("______________________________________________");
                Console.WriteLine("|                                            |");
                Console.WriteLine("|                                            |");
                Console.WriteLine("|                                            |");
                Console.WriteLine("|                                            |");
                Console.WriteLine("|                                            |");
                Console.WriteLine("|                   Booting                  |");
                Console.WriteLine("|                                            |");
                if (i == 0) Console.WriteLine("|                     0%                     |");
                else if (i == 1) Console.WriteLine("|                     6%                     |");
                else if (i % 2 == 0) Console.WriteLine($"|                     {i * 6.5}%                    |");
                else Console.WriteLine($"|                    {i * 6.5}%                   |");
                Console.Write("|               ");
                for (int j = 0; j < i; j++)
                {
                    Console.Write("|");
                }
                for (int j = 0; j < (15 - i); j++)
                {
                    Console.Write(" ");
                }
                Console.Write("              |\n");
                Console.WriteLine("|                                            |");
                Console.WriteLine("|                                            |");
                Console.WriteLine("|                                            |");
                Console.WriteLine("|                                            |");
                Console.WriteLine("|                                            |");
                Console.WriteLine("----------------------------------------------");
                Thread.Sleep(rand.Next(1, 15) /* 1000*/);
                Console.Clear();
            }
            program.PrintLine("Welcome adventurer, you have been issued a very special quest by the guild!  \nYou are supposed to search the NAME for the extremly uniqe item \"ITEM\", whitch is most likely guarded my some kind of beast!");
            Console.ReadKey();
            Console.Clear();
            program.PrintLine("You have also heard that this is a weird doungeon that eats explorers, because of this the elders gifted you a needle") ;
            Console.ReadKey();
            Console.Clear();
            program.PrintLine("As you approch the cavern in witch the dongeon is located you see that there are signs that say \"K?e?? ?ut\" and \"?av??yo?se??s!!\"       \nYou obviusly ignore them and enter the first chamber.") ;
            Console.ReadKey();
            while (hp > 0 && win)
            {
                Console.Clear();
                program.Print("do you want to go \"north\", \"west\", \"south\", \"east\"");
                if (map[y, x] == 1) program.PrintLine(", \"loot\", or see your \"stats\"");
                else program.PrintLine(", or see your \"stats\"");
                opt = Console.ReadLine();
                if (opt == "loot" && map[y, x] == 1)
                {
                    temp = rand.Next(0, 100);
                    if (xp > next)
                    {
                        maxinv++;
                        program.PrintLine("you found a small backpack!");
                        next += 1000;
                    }
                    else if (temp < 40 && inv.Count() <= maxinv)
                    {
                        temp = rand.Next(items.Length);
                        program.PrintLine("do you want " + items[temp] + "?");
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
                        program.PrintLine("do you want " + items[temp] + "?");
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
                    map[y, x] = 0;
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
                else if (opt == "north")
                {
                    if (x != 0)
                    {
                        x--;
                        program.PrintLine("the door opens!");
                    }
                    else
                    {
                        Console.WriteLine("there is no door? Weird\nYou bump your head and hurt yourself");
                        hp--;
                    }
                    if (map[y, x] == -1 && map[2, 21] != -5)
                    {
                        win = false;
                    }
                    else if (map[y, x] == -1 && map[2, 21] == -5)
                    {
                        program.PrintLine("it seems that there is a massive lift in here             \nit is not functional, apperantly there is a glitch somewhere?");
                    }
                    else if (map[y, x] == -3 && map[20, 34] == -2)
                    {
                        Console.WriteLine("The door dosen't open, apperantly the Judge has the key");
                        x++;
                    }
                    else if (map[y, x] == -4 && map[200, 43] == -3)
                    {
                        Console.WriteLine("The door dosen't open, apperantly the Jurry has the key");
                        x++;
                    }
                    else if (map[y, x] == -5 && map[32, 150] == -4)
                    {
                        Console.WriteLine("The door dosen't open, apperantly the Exocutioner has the key");
                        x++;
                    }
                    Console.ReadLine();
                }
                else if (opt == "east")
                {
                    if (y != 255)
                    {
                        y++;
                        program.PrintLine("the door opens!");
                    }
                    else
                    {
                        Console.WriteLine("there is no door? Weird\nYou bump your head and hurt yourself");
                        hp--;
                    }
                    if (map[y, x] == -1 && map[2, 21] != -5)
                    {
                        win = false;
                    }
                    else if (map[y, x] == -1 && map[2, 21] == -5)
                    {
                        program.PrintLine("it seems that there is a massive lift in here             \nit is not functional, apperantly there is a glitch somewhere?");
                    }
                    else if (map[y, x] == -3 && map[20, 34] == -2)
                    {
                        Console.WriteLine("The door dosen't open, apperantly the Judge has the key");
                        y--;
                    }
                    else if (map[y, x] == -4 && map[200, 43] == -3)
                    {
                        Console.WriteLine("The door dosen't open, apperantly the Jurry has the key");
                        y--;
                    }
                    else if (map[y, x] == -5 && map[32, 150] == -4)
                    {
                        Console.WriteLine("The door dosen't open, apperantly the Exocutioner has the key");
                        y--;
                    }
                    Console.ReadLine();
                }
                else if (opt == "south")
                {
                    if (x != 255)
                    {
                        x++;
                        program.PrintLine("the door opens!");
                    }
                    else
                    {
                        Console.WriteLine("there is no door? Weird\nYou bump your head and hurt yourself");
                        hp--;
                    }
                    if (map[y, x] == -1 && map[2, 21] != -5)
                    {
                        win = false;
                    }
                    else if (map[y, x] == -1 && map[2, 21] == -5)
                    {
                        program.PrintLine("it seems that there is a massive lift in here             \nit is not functional, apperantly there is a glitch somewhere?");
                    }
                    else if (map[y, x] == -3 && map[20, 34] == -2)
                    {
                        Console.WriteLine("The door dosen't open, apperantly the Judge has the key");
                        x--;
                    }
                    else if (map[y, x] == -4 && map[200, 43] == -3)
                    {
                        Console.WriteLine("The door dosen't open, apperantly the Jurry has the key");
                        x--;
                    }
                    else if (map[y, x] == -5 && map[32, 150] == -4)
                    {
                        Console.WriteLine("The door dosen't open, apperantly the Exocutioner has the key");
                        x--;
                    }
                    Console.ReadLine();
                }
                else if (opt == "west")
                {
                    if (y != 0)
                    {
                        y--;
                        program.PrintLine("the door opens!");
                    }
                    else
                    {
                        Console.WriteLine("there is no door? Weird\nYou bump your head and hurt yourself");
                        hp--;
                    }
                    if (map[y, x] == -1 && map[2, 21] != -5)
                    {
                        win = false;
                    }
                    else if (map[y, x] == -1 && map[2, 21] == -5)
                    {
                        program.PrintLine("it seems that there is a massive lift in here             \nit is not functional, apperantly there is a glitch somewhere?");
                    }
                    else if (map[y, x] == -3 && map[20, 34] == -2)
                    {
                        Console.WriteLine("The door dosen't open, apperantly the Judge has the key");
                        x++;
                    }
                    else if (map[y, x] == -4 && map[200, 43] == -3)
                    {
                        Console.WriteLine("The door dosen't open, apperantly the Jurry has the key");
                        x++;
                    }
                    else if (map[y, x] == -5 && map[32, 150] == -4)
                    {
                        Console.WriteLine("The door dosen't open, apperantly the Exocutioner has the key");
                        x++;
                    }
                    Console.ReadLine();
                }
                switch (map[y, x])
                {
                    case -2:
                        name = "Judge";
                        ehp = 1260;
                        eres = 1.5F;
                        edmg = 20;
                        res -= 0.1F;
                        break;
                    case -3:
                        name = "Jurry";
                        ehp = 5000;
                        eres = 0.2F;
                        edmg = 100;
                        break;
                    case -4:
                        name = "exocutioner";
                        ehp = 10000;
                        eres = 10;
                        edmg = 60;
                        hp *= 0.8F;
                        break;
                    case -5:
                        name = "err";
                        ehp = 1073741824;
                        eres = 1073741824;
                        edmg = 1073741824;
                        break;
                    case 2:
                        name = "skeleton";
                        ehp = rand.Next(10, 21);
                        eres = rand.Next(5, 14) / 100;
                        edmg = rand.Next(5, 11);
                        break;
                    case 3:
                        name = "knight";
                        ehp = rand.Next(23, 31);
                        eres = rand.Next(95, 100) / 100;
                        edmg = rand.Next(15, 20);
                        break;
                    default:
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
                            try
                            {
                                temp = int.Parse(Console.ReadLine());
                                templist = program.ItemStats(inv[temp]);
                            }
                            catch
                            {
                                Console.WriteLine("out of range, defaulting to standard weapon");
                                templist = new List<float> { 0, 0 };
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
                        map[y, x] = 1;
                    }
                }
            }
            Console.Clear();
            Console.WriteLine("\\        /      _____      |           |       |              _____          _____        _____   _________");
            Console.WriteLine(" \\      /      /     \\     |           |       |             /     \\        /     \\      /     \\  |        ");
            Console.WriteLine("  \\    /      /       \\    |           |       |            /       \\      /       \\    (         |        ");
            Console.WriteLine("   \\  /      /         \\   |           |       |           /         \\    /         \\    \\        |        ");
            Console.WriteLine("    \\/      (           )  |           |       |          (           )  (           )    \\.      L_____   ");
            Console.WriteLine("    /       (           )  (           )       |          (           )  (           )      \\.    |        ");
            Console.WriteLine("   /         \\         /    \\         /        |           \\         /    \\         /         \\   |        ");
            Console.WriteLine("  /           \\       /      \\       /         |            \\       /      \\       /           )  |        ");
            Console.WriteLine(" /             \\     /        \\     /          |             \\     /        \\     /     \\     /   |        ");
            Console.WriteLine("/               -----          -----           ---------      -----          -----       -----    L________");
            Thread.Sleep(3000);
            if (!win)
            {
                Console.Clear();
                program.Print("Oh wait!      \nthat's the wrong screen! Let me see if i can fix this");
                Thread.Sleep(1000);
                Console.Write(".");
                Thread.Sleep(1000);
                Console.Write(".");
                Thread.Sleep(1000);
                Console.WriteLine(".");
                program.PrintLine("here we go!");
                Console.WriteLine("\\        /      _____      |           |       |              _____          _____        _____   _________");
                Console.WriteLine(" \\      /      /     \\     |           |       |             /     \\        /     \\      /     \\  |        ");
                Console.WriteLine("  \\    /      /       \\    |           |       |            /       \\      /       \\    (         |        ");
                Console.WriteLine("   \\  /      /         \\   |           |       |           /         \\    /         \\    \\        |        ");
                Console.WriteLine("    \\/      (           )  |           |       |          (           )  (           )    \\.      L_____   ");
                Console.WriteLine("    /       (           )  (           )       |          (           )  (           )      \\.    |        ");
                Console.WriteLine("   /         \\         /    \\         /        |           \\         /    \\         /         \\   |        ");
                Console.WriteLine("  /           \\       /      \\       /         |            \\       /      \\       /           )  |        ");
                Console.WriteLine(" /             \\     /        \\     /          |             \\     /        \\     /     \\     /   |        ");
                Console.WriteLine("/               -----          -----           ---------      -----          -----       -----    L________");
                Thread.Sleep(3000);
                Console.Clear();
                program.PrintLine("Darn, it seems i lost the screen,     \nanyhow, congrats! I wase'nt expecting you to make it Adventurer, I guess something something the guild punishes you for not getting the item?   \nHere are your stats:");
            }

            Console.WriteLine($"player:\nHp: {hp}\nResistance: {res * 100}%\nbase damage: {dmg}-{dmg + 5}\nLvL: {xp / 1000 + 1} Xp: {xp}\nKills: {kills}\nInventory size: {maxinv + 1}\n\n");
            Console.WriteLine("inventory:");
            for (int i = 0; i < inv.Count(); i++)
            {
                Console.WriteLine((i) + " " + items[inv[i]]);
            }
            Console.ReadKey();

        }
    }
}
