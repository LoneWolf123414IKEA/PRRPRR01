using System;

namespace tba
{
    class program
    {
        static List<float> ItemStats(int id)
        {
            var list = new List<float>();
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
        static void PrintLn(string text)
        {
            foreach (char i in text)
            {
                Console.Write(i);
                Thread.Sleep(10);
            }
            Console.Write("\n");
        }
        static void Print(string text)
        {
            foreach (char i in text)
            {
                Console.Write(i);
                Thread.Sleep(10);
            }
        }
        static void Main(string[] args)
        {
            bool sav = false;
            Console.Write("Load a file? (y/n) ");
            if (Console.ReadLine() == "y") sav = true;
            Console.Clear();

                



            int?[,] map = new int?[260, 260];
            int x;
            int y;
            int lastx;
            int lasty;
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
            int maxinv;
            Random rand = new Random();
            float hp;
            float res;
            int dmg;
            float ehp;
            float eres = 0;
            int edmg = 0;
            float tempdmg;
            float etempdmg;
            string? opt;
            int temp;
            var templist = new List<float>();
            string name = "";
            Console.SetWindowSize(160, 40);
            Print("I herby declare that i ");
            string plname = Console.ReadLine();
            Console.SetCursorPosition(23 + plname.Length, 0);
            PrintLn(" will serve the eternal guild with my soul untill i am released, i also am aware that if i shuld fall during the completion of a quest my mind and soul will be retured to the time and place i was issued that quest.");
            Console.Read();
            
            
            
            TextReader svf = new StreamReader("sco.txt");
            while(true)
            {
                opt = svf.ReadLine()
                if (opt == null)
                {
                    
                }
                else if (plname == opt.Split("¦")[0])
                {
                    
                }
            }
            
            svf.Close();
            sav = false;
            
            
            int xp;
            int next;
            int kills = 0;
            bool win;
            bool surr = true;







            while (true)
            {
                if (sav)
                {
                    TextReader svf = new StreamReader("sav.txt");
                    xp = int.Parse(svf.ReadLine());
                    next = int.Parse(svf.ReadLine());
                    for (int i = 1; i < int.Parse(svf.ReadLine()); i++) Console.WriteLine(svf.ReadLine());
                    win = true;
                    maxinv = int.Parse(svf.ReadLine());
                    hp = float.Parse(svf.ReadLine());
                    res = float.Parse(svf.ReadLine());
                    dmg = int.Parse(svf.ReadLine());
                    ehp = 0;
                    for (int y1 = 0; y1 < 260; y1++)
                    {
                        for (int x1 = 0; x1 < 260; x1++)
                        {
                            map[x1, y1] = int.Parse(svf.ReadLine());
                        }
                    }
                    y = int.Parse(svf.ReadLine());
                    x = int.Parse(svf.ReadLine());
                    lastx = int.Parse(svf.ReadLine());
                    lasty = int.Parse(svf.ReadLine());

                    svf.Close();
                    sav = false;
                }
                else
                {
                    xp = 0;
                    next = 1000;
                    inv.Clear();
                    inv.Add(2);
                    win = true;
                    maxinv = 2;
                    hp = 125;
                    res = 0.05F;
                    dmg = 5;
                    ehp = 0;



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
                    y = 0;
                    x = 0;
                    lastx = 0;
                    lasty = 0;
                }
                
                /*
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
                    Thread.Sleep(rand.Next(1, 15) * 1000);
                    Console.Clear();
                }
                PrintLn("Welcome adventurer, you have been issued a very special quest by the guild!  \nYou are supposed to search the NAME for the extremly uniqe item \"ITEM\", whitch is most likely guarded my some kind of beast!");
                Console.ReadKey();
                Console.Clear();
                PrintLn("You have also heard that this is a weird doungeon that eats explorers, because of this the elders gifted you a needle");
                Console.ReadKey();
                Console.Clear();
                PrintLn("As you approch the cavern in witch the dungeon is located you see that there are signs that say \"K?e?? ?ut\" and \"?av??yo?se??s!!\"       \nYou obviusly ignore them and enter the first chamber.");
                Console.ReadKey();
                */




                while (hp > 0 && win)
                {

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
                    Console.WriteLine(name);
                    while (ehp > 0 && hp > 0)
                    {
                        Console.Clear();
                        PrintLn($"{name}:\nHp: {ehp}\nRes: {eres}\nDmg: {edmg}-{edmg + 5}\n\nPlayer:\nHp: {hp}\nRes: {res}\nDmg: {dmg}-{dmg + 5}\n");
                        Print("1. attack");
                        Thread.Sleep(200);
                        Print(" 2. item");
                        Thread.Sleep(200);
                        PrintLn(" 3. run");
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
                                    PrintLn("Enemy resisted");
                                }
                                break;
                            case "2":
                                PrintLn("choose item");
                                for (int i = 0; i < inv.Count(); i++)
                                {
                                    PrintLn((i) + " " + items[inv[i]]);
                                }
                                try
                                {
                                    temp = int.Parse(Console.ReadLine());
                                    templist = ItemStats(inv[temp]);
                                }
                                catch
                                {
                                    PrintLn("out of range, defaulting to standard weapon");
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
                                res -= 0.1F;
                                ehp = 0;
                                x = lastx;
                                y = lasty;
                                PrintLn($"You ran away but the {name} destroyed some of your armour");
                                surr = false;
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
                            PrintLn("You resisted");
                            res -= 0.01F;
                        }
                        PrintLn($"You did {tempdmg} damage\nYou lost {etempdmg} health");
                        hp -= etempdmg;
                        ehp -= tempdmg;
                        Console.ReadKey();
                        if (ehp <= 0 && surr)
                        {
                            xp += rand.Next(10);
                            kills++;
                            map[y, x] = 1;
                        }
                        else if (ehp <= 0 && !surr) surr = true;
                            
                    }
                    Console.Clear();
                    PrintLn($"player:\nHp: {hp}\nResistance: {res * 100}%\nbase damage: {dmg}-{dmg + 5}\nLvL: {xp / 1000 + 1} Xp: {xp}\nKills: {kills}\nInventory size: {maxinv + 1}\n\n");
                    PrintLn("inventory:");
                    for (int i = 0; i < inv.Count(); i++)
                    {
                        PrintLn((i) + " " + items[inv[i]]);
                    }
                    Console.WriteLine();
                    Print("do you want to \"save\"");
                    if (map[y, x] == 1) Print(", \"loot\" the room");
                    if (map[y, x] <= 1 && map[y, x] >= -1) Print(", or go \"north\", \"west\", \"south\", or \"east\"");
                    Console.WriteLine("?");
                    opt = Console.ReadLine();
                    if (opt == "loot" && map[y, x] == 1)
                    {
                        temp = rand.Next(0, 100);
                        if (xp > next)
                        {
                            maxinv++;
                            PrintLn("you found a small backpack!");
                            next += 1000;
                        }
                        else if (temp < 40 && inv.Count() <= maxinv)
                        {
                            temp = rand.Next(items.Length);
                            PrintLn("do you want " + items[temp] + "?");
                            opt = Console.ReadLine();
                            if (opt == "yes" && temp != 2)
                            {
                                inv.Add(temp);
                            }
                            else if (opt == "yes")
                            {
                                inv.Add(3);
                            }
                            if (inv[0] == 2) inv.RemoveAt(0);
                        }
                        else if (temp < 40 && inv.Count() > maxinv)
                        {
                            temp = rand.Next(items.Length);
                            PrintLn("do you want " + items[temp] + "?");
                            opt = Console.ReadLine();
                            if (opt == "yes" && temp != 2)
                            {
                                for (int i = 0; i < inv.Count(); i++)
                                {
                                    PrintLn((i + 1) + " " + items[inv[i]]);
                                }
                                PrintLn("\nchoose item to discard");
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
                            else if (opt == "yes")
                            {
                                inv.RemoveAt(0);
                                inv.Add(3);
                            }
                        }
                        else if (temp < 52)
                        {
                            res += rand.Next(0, xp) / 100;
                            PrintLn("You found some armour");
                            Console.ReadKey();
                        }
                        else
                        {
                            PrintLn("you found nothing");
                            Console.ReadKey();
                        }
                        map[y, x] = 0;
                    }
                    else if (opt == "save")
                    {
                        TextWriter wsv = new StreamWriter("sav.txt");

                        wsv.WriteLine(xp);
                        wsv.WriteLine(next);
                        wsv.WriteLine(inv.Count());
                        foreach (int i in inv) wsv.WriteLine(i);
                        wsv.WriteLine(maxinv);
                        wsv.WriteLine(hp);
                        wsv.WriteLine(res);
                        wsv.WriteLine(dmg);
                        ehp = 0;
                        for (int y1 = 0; y1 < 260; y1++)
                        {
                            for (int x1 = 0; x1 < 260; x1++)
                            {
                                wsv.WriteLine(map[x1, y1]);
                            }
                        }
                        wsv.WriteLine(y);
                        wsv.WriteLine(x);
                        wsv.WriteLine(lastx);
                        wsv.WriteLine(lasty);

                        wsv.Close();
                    }
                    else if (opt == "north")
                    {
                        if (x != 0)
                        {
                            x--;

                            PrintLn("you try the door");
                        }
                        else
                        {
                            PrintLn("there is no door? Weird\nYou bump your head and hurt yourself");
                            hp--;
                        }
                        if (map[y, x] == -1 && map[2, 21] != -5)
                        {
                            win = false;
                        }
                        else if (map[y, x] == -1 && map[2, 21] == -5)
                        {
                            PrintLn("it seems that there is a massive lift in here         \nit is not functional, apperantly there is a glitch somewhere?");
                            lastx = x++;
                        }
                        else if (map[y, x] == -3 && map[20, 34] == -2)
                        {
                            PrintLn("The door dosen't open, apperantly the Judge has the key");
                            x++;

                        }
                        else if (map[y, x] == -4 && map[200, 43] == -3)
                        {
                            PrintLn("The door dosen't open, apperantly the Jurry has the key");
                            x++;
                        }
                        else if (map[y, x] == -5 && map[32, 150] == -4)
                        {
                            PrintLn("The door dosen't open, apperantly the Exocutioner has the key");
                            x++;
                        }
                        else lastx = x + 1;
                        Console.ReadLine();
                    }
                    else if (opt == "east")
                    {
                        if (y != 255)
                        {
                            y++;
                            PrintLn("You try the door");
                        }
                        else
                        {
                            PrintLn("there is no door? Weird\nYou bump your head and hurt yourself");
                            hp--;
                        }
                        if (map[y, x] == -1 && map[2, 21] != -5)
                        {
                            win = false;
                        }
                        else if (map[y, x] == -1 && map[2, 21] == -5)
                        {
                            PrintLn("it seems that there is a massive lift in here         \nit is not functional, apperantly there is a glitch somewhere?");
                            lasty = y--;
                        }
                        else if (map[y, x] == -3 && map[20, 34] == -2)
                        {
                            PrintLn("The door dosen't open, apperantly the Judge has the key");
                            y--;
                        }
                        else if (map[y, x] == -4 && map[200, 43] == -3)
                        {
                            PrintLn("The door dosen't open, apperantly the Jurry has the key");
                            y--;
                        }
                        else if (map[y, x] == -5 && map[32, 150] == -4)
                        {
                            PrintLn("The door dosen't open, apperantly the Exocutioner has the key");
                            y--;
                        }
                        else lasty = y - 1;
                        Console.ReadLine();
                    }
                    else if (opt == "south")
                    {
                        if (x != 255)
                        {
                            x++;
                            PrintLn("You try the door");
                        }
                        else
                        {
                            PrintLn("there is no door? Weird\nYou bump your head and hurt yourself");
                            hp--;
                        }
                        if (map[y, x] == -1 && map[2, 21] != -5)
                        {
                            win = false;
                        }
                        else if (map[y, x] == -1 && map[2, 21] == -5)
                        {
                            PrintLn("it seems that there is a massive lift in here         \nit is not functional, apperantly there is a glitch somewhere?");
                            lastx = x--;
                        }
                        else if (map[y, x] == -3 && map[20, 34] == -2)
                        {
                            PrintLn("The door dosen't open, apperantly the Judge has the key");
                            x--;
                        }
                        else if (map[y, x] == -4 && map[200, 43] == -3)
                        {
                            PrintLn("The door dosen't open, apperantly the Jurry has the key");
                            x--;
                        }
                        else if (map[y, x] == -5 && map[32, 150] == -4)
                        {
                            PrintLn("The door dosen't open, apperantly the Exocutioner has the key");
                            x--;
                        }
                        else lastx = x - 1;
                        Console.ReadLine();
                    }
                    else if (opt == "west")
                    {
                        if (y != 0)
                        {
                            y--;
                            PrintLn("You try the door");
                        }
                        else
                        {
                            PrintLn("there is no door? Weird\nYou bump your head and hurt yourself");
                            hp--;
                        }
                        if (map[y, x] == -1 && map[2, 21] != -5)
                        {
                            win = false;
                        }
                        else if (map[y, x] == -1 && map[2, 21] == -5)
                        {
                            PrintLn("it seems that there is a massive lift in here         \nit is not functional, apperantly there is a glitch somewhere?");
                            lasty = y++;
                        }
                        else if (map[y, x] == -3 && map[20, 34] == -2)
                        {
                            PrintLn("The door dosen't open, apperantly the Judge has the key");
                            y++;
                        }
                        else if (map[y, x] == -4 && map[200, 43] == -3)
                        {
                            PrintLn("The door dosen't open, apperantly the Jurry has the key");
                            y++;
                        }
                        else if (map[y, x] == -5 && map[32, 150] == -4)
                        {
                            PrintLn("The door dosen't open, apperantly the Exocutioner has the key");
                            y++;
                        }
                        else lasty = y + 1;
                        Console.ReadLine();
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
                    Print("Oh wait!      \nthat's the wrong screen! Let me see if i can fix this");
                    Thread.Sleep(1000);
                    Console.Write(".");
                    Thread.Sleep(1000);
                    Console.Write(".");
                    Thread.Sleep(1000);
                    Console.WriteLine(".");
                    PrintLn("here we go!");
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
                    PrintLn("Darn, it seems i lost the screen,     \nanyhow, congrats! I wasen't expecting you to make it Adventurer, I guess something something the guild punishes you for not getting the item?\nThanks for dedicating enough time to this game to make it here, if you'd like to critisize me or leave feedback, contact me at discord here: https://discord.gg/GHttQNw6w4                   \n\nHere are your stats:");
                }
                else if (kills > 99)
                {
                    PrintLn("\nBut Very impressive performance, you killded over 100 enemies!\nI can give you another chanse though, we will reset most of your stats and your invntory but if you maneged to kill that many enemies you can't be that far from winning!\nI belive in you Adventurer! If you'd like to critisize me or leave feedback, contact me at discord here: https://discord.gg/GHttQNw6w4                   \n\nHere are your stats:");
                }
                else if (x + y != 0)
                {
                    PrintLn("I've seen worse preformances, you have potential! Keep trying, i'll even let you keep some of your stats! If you'd like to critisize me or leave feedback contact me at discord here: https://discord.gg/GHttQNw6w4                   \n\nHere are your stats:");
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
}
/*
TextWriter wsv = new StreamWriter("sav.txt");
            wsv.WriteLine("Eloo, World");
            wsv.Close();
            TextReader svf = new StreamReader("sav.txt");
            Console.Write(svf.ReadLine());
            svf.Close();
*/
