using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Weapon
    {
        public int Protect { get; set; }
        public int Firearm { get; set; }
        public int СoldSteel { get; set; }
        public Weapon(string name)
        {
            Protect = 100;
            Firearm = 100;
            СoldSteel = 50;
        }
        public void Protection(Person player1)
        {
            player1.HealthPoint += Protect;
        }
        public void Fire(Person target)
        {
            target.Damage -= Firearm;
        }
        public void Cold(Person target)
        {
            target.Damage -= СoldSteel;
        }

    }
}
