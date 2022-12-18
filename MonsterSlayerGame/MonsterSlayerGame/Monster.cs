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
        public string Weapon;
        public Monster(string name, int health, string weapon)
        {
            Name = name;
            Health = health;
            Weapon = weapon;
        }
    }
}
