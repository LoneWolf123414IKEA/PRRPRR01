using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Linq;

namespace tba
{
    class items
    {
        public static float[,] id =
        {
            { 1, 10 },
            { 1, 11 },
            { 1, 4242 },
            { 0, 0 },
            { 2, 1 },
            { 2, 0.1F },
            { 0, 1 },
            { 2, 10 }
        };
    }
    class fight
    {

    }
    class move
    {
        private static Random rand = new Random();
        public static int?[,] map = new int?[260, 260];
        public static int x;
        public static int y;
        private static int lastx;
        private static int lasty;
        static public void mapgen(string name)
        {
            if (name == "¦")
            {
                for (int y1 = 0; y1 < 260; y1++)
                {
                    for (int x1 = 0; x1 < 260; x1++)
                    {
                        map[x1, y1] = rand.Next(0, 4);
                    }
                }
                map[0, 0] = 1;
                map[255, 1] = -1;
                map[20, 34] = -2;
                map[200, 43] = -3;
                map[32, 150] = -4;
                map[2, 21] = -5;
            }
            else
            {
                TextReader mapl = new StreamReader("map" + name + ".txt");
                for (int y1 = 0; y1 < 260; y1++)
                {
                    for (int x1 = 0; x1 < 260; x1++)
                    {
                        map[x1, y1] = int.Parse(mapl.ReadLine());
                    }
                }
                y = int.Parse(mapl.ReadLine());
                x = int.Parse(mapl.ReadLine());
                lastx = int.Parse(mapl.ReadLine());
                lasty = int.Parse(mapl.ReadLine());
                mapl.Close();
            }

        }
        static public void North()
        {
            if (x != 0)
            {
                if (map[x-1, y] < 0)
                {
                    chr.ill++;
                }
                else
                {
                    lastx = x;
                    x--;
                    chr.spll++;
                }
            }
            else
            {
                chr.hp--;
                chr.ill++;
            }
            
        }
        static public void South()
        {
            if (x != 255)
            {
                if (map[x + 1, y] < 0)
                {
                    chr.ill++;
                }
                else
                {
                    lastx = x;
                    x++;
                    chr.spll++;
                }
            }
            else
            {
                chr.hp--;
                chr.ill++;
            }
        }
        static public void East()
        {
            if (y != 0)
            {
                if (map[x, y + 1] < 0)
                {
                    chr.ill++;
                }
                else
                {
                    lasty = y;
                    y++;
                    chr.spll++;
                }
            }
            else
            {
                chr.hp--;
                chr.ill++;
            }
        }
        static public void West()
        {
            if (y != 0)
            {
                if (map[x, y-1] < 0)
                {
                    chr.ill++;
                }
                else
                {
                    lasty = y;
                    y--;
                    chr.spll++;
                }
            }
            else
            {
                chr.hp--;
                chr.ill++;
            }
        }
    }
    class chr
    {
        public static string name;
        public static float hp;
        public static float res;
        public static int dmg;
        public static List<int> inv = new List<int>();
        public static int maxinv;
        public static int xp;
        public static int ill;
        public static int spll;
        static public void Chgen()
        {
            

            hp = 125;
            res = 0.05F;
            dmg = 5;
            xp = 0;
            ill = 0;
            spll = 0;
            maxinv = 3;
            inv.Add(2);
        }
        static public void Chload(string nam)
        {
            TextReader Chl = new StreamReader("save" + nam + ".txt");
            name = Chl.ReadLine();
            hp = float.Parse(Chl.ReadLine());
            res = float.Parse(Chl.ReadLine());
            dmg = int.Parse(Chl.ReadLine());
            xp = int.Parse(Chl.ReadLine());
            ill = int.Parse(Chl.ReadLine());
            spll = int.Parse(Chl.ReadLine());
            maxinv = int.Parse(Chl.ReadLine());
            inv = Chl.ReadLine().Split("¦").Select(Int32.Parse).ToList();
            Chl.Close();
        }
        static public void Chsave()
        {
            StreamWriter Chs = new StreamWriter("save" + name + ".txt");
            Chs.WriteLine(name);
            Chs.WriteLine(hp);
            Chs.WriteLine(res);
            Chs.WriteLine(dmg);
            Chs.WriteLine(xp);
            Chs.WriteLine(ill);
            Chs.WriteLine(spll);
            Chs.WriteLine(maxinv);
            foreach (int i in inv)
            {
                Chs.Write(i + "¦");
            }
            Chs.Close();
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("do you want to load a saved game? (y/n)");
            if (Console.ReadLine() == "y")
            {
                Console.WriteLine("input name of saved character");
                chr.Chload(Console.ReadLine());
                move.mapgen(chr.name);
            }
            else
            {
                Console.Clear();
                Console.Write("I herby declare that i ");
                chr.name = Console.ReadLine();
                if (File.Exists("save" + chr.name + ".txt"))
                {
                    System.Environment.Exit(0);
                }
                Console.SetCursorPosition(23 + chr.name.Length, 0);
                Console.WriteLine(" will serve the eternal guild with my soul untill i am released, i also am aware that if i shuld fall during the completion of a quest my mind and soul will be retured to the time and place i was issued that quest.");
                Console.Read();
                chr.Chgen();
                move.mapgen("¦");
            }
            chr.Chsave();

        }
    }
}
