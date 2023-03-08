using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TBA;

namespace TBA
{
    internal class move
    {
        private  Random rand = new Random();
        public  int?[,] map = new int?[260, 260];
        public  int x;
        public  int y;
        private  int lastx;
        private  int lasty;
        public void mapgen(string name)
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
                StreamReader mapl = new StreamReader(name + ".map");
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
        public void mapsave(string name)
        {
            StreamWriter Mps = new StreamWriter(name + ".map");
            foreach (int i in map)
            {
                Mps.WriteLine(i);
            }
            Mps.WriteLine(y);
            Mps.WriteLine(x);
            Mps.WriteLine(lastx);
            Mps.WriteLine(lasty);
            Mps.Close();
        }
        public void North()
        {
            if (x != 0)
            {
                if (map[x - 1, y] < 0)
                {
                    Program.player.ill++;
                }
                else
                {
                    lastx = x;
                    x--;
                    Program.player.spll++;
                }
            }
            else
            {
                Program.player.hp--;
                Program.player.ill++;
            }

        }
         public void South()
        {
            if (x != 255)
            {
                if (map[x + 1, y] < 0)
                {
                    Program.player.ill++;
                }
                else
                {
                    lastx = x;
                    x++;
                    Program.player.spll++;
                }
            }
            else
            {
                Program.player.hp--;
                Program.player.ill++;
            }
        }
         public void East()
        {
            if (y != 0)
            {
                if (map[x, y + 1] < 0)
                {
                    Program.player.ill++;
                }
                else
                {
                    lasty = y;
                    y++;
                    Program.player.spll++;
                }
            }
            else
            {
                Program.player.hp--;
                Program.player.ill++;
            }
        }
         public void West()
        {
            if (y != 0)
            {
                if (map[x, y - 1] < 0)
                {
                    Program.player.ill++;
                }
                else
                {
                    lasty = y;
                    y--;
                    Program.player.spll++;
                }
            }
            else
            {
                Program.player.hp--;
                Program.player.ill++;
            }
        }
    }
}
