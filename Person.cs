using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public class Person
    {
        int hp;
        public int HealthPoint
        {
            get
            {
                return hp;
            }
            set
            {
                if (value < 0)
                {
                    Alive = false;
                    hp = 0;
                }
                else
                    hp = value;
            }
        }
        public int Level { get; set; }
        public int Damage { get; set; }
        public string Name { get; set; }
        public bool Alive { get; set; } = true;
        public Person(string name)
        {
            Name = name;
            HealthPoint = 100;
            Level = 1;
            Damage = 50;
        }

        public void LevelUp()
        {
            Level++;
        }

        public void Hit(Person target)
        {
            if(Alive)
            {
                Random random = new Random();
                target.HealthPoint -= random.Next(Damage - 10, Damage + 11);
                if (target.HealthPoint == 0)
                    LevelUp();
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Hi,I'm {Name},my hp:{HealthPoint}, dmg: {Damage}, lvl:{Level}");
        }

    }
}
