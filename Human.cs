using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    public class Human
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Dexterity { get; set; }
        public int Health { get; set; }

        public Human(string name)
        {
            this.Name = name;
            this.Strength = 3;
            this.Intelligence = 3;
            this.Dexterity = 3;
            this.Health = 100;
        }

        public Human(string name, int streng, int intel, int dex, int health)
        {
            this.Name = name;
            this.Strength = streng;
            this.Intelligence = intel;
            this.Dexterity = dex;
            this.Health = health;
        }

        public virtual void Attack(Object obj)
        {
            Human enemy = (Human)obj;
            if (enemy == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                enemy.Health -= 5 * this.Strength;
            }
        }
    }
}
