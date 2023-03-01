using System.Collections.Generic;
namespace tba
{
    class items
    {

    }
    class fight
    {

    }
    class movement
    {
        private Random rand = new Random();
        public int?[,] map = new int?[260, 260];
        public int x;
        public int y;
        private int lastx;
        private int lasty;
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
    }
    class Program
    {

    }
}
