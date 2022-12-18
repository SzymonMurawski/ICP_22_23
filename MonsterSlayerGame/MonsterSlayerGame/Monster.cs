using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayerGame
{
    public class Monster
    {
        public string Name;
        public int Health;
        public string[] Weapons;
        private Random random = new Random();
        public Monster(string name, int health, string[] weapons)
        {
            Name = name;
            Health = health;
            Weapons = weapons;
        }
        public string GetNextWeapon()
        {
            return Weapons[random.Next(Weapons.Length)];
        }
    }
}
