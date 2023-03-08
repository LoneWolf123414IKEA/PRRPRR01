using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBA
{
    internal class items
    {
        public float[,] id =
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
        public string[] names =
        {
            "Club",
            "Wood Sword",
            "Needle",
            "Anchient Weapon",
            "Small Heal",
            "Smaller Heal",
            "HealthKit",
            "Stimpack"
        };

        public List<int> inv = new List<int>();
        public int maxinv;

        public void invgen(string name)
        {
            if (name == "¦")
            {
                maxinv = 3;
                inv.Add(2);
            }
            else
            {
                StreamReader inl = new StreamReader(name + ".inv");
                maxinv = int.Parse(inl.ReadLine());
                inv = inl.ReadLine().Split("¦").Select(Int32.Parse).ToList();
                inl.Close();
            }
        }

        public void invsave(string name)
        {
            StreamWriter ins = new StreamWriter(name + ".inv");
            ins.WriteLine(maxinv);
            ins.Write(inv[0]);
            for (int i = 1; i < inv.Count(); i++) ins.Write("¦" + inv[i]);
            ins.Close();
        }
    }
}
