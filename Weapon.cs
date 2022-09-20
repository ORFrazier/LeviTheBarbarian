using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevitheBarbarian
{
    public class Weapon
    {
        public int weapon;
        public string name;

        public static void CreateWeapons()
        {
            Weapon a = new Weapon();
            a.weapon = 1;
            Console.WriteLine("Weapon: " + a.weapon);

            Weapon b = new Weapon();
            b.weapon = 2;
            Console.WriteLine("Weapon: " + b.weapon);

            Weapon c = new Weapon();
            c.weapon = 3;
            Console.WriteLine("Weapon: " + c.weapon);

            if (a.weapon == 1)
            {
                Console.WriteLine(a.name);
            }
            if (b.weapon == 2)
            {
                Console.WriteLine(b.name);
            }
            if (c.weapon == 3)
            {
                Console.WriteLine(c.name);
            }
        }
    }
}
