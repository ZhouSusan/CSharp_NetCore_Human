using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Wizard : Human
    {
        public Wizard(string name) : base (name)
        {
            this.Health = 50;
            this.Intelligence = 25;
        }

        public int Heal(Wizard wiz)
        {
            wiz.Health += (10 * this.Intelligence);
            return wiz.Health;
        } 

        public int Fireball(Object obj)
        {
            Random rand = new Random();
            int dmg = rand.Next(20, 51);

            Human humanEnemy = (Human)obj;
            Wizard wizardEnemy = (Wizard)obj;
            Ninja ninjaEnemy = (Ninja)obj;
            Samurai samuraiEnemy = (Samurai)obj;

            if(humanEnemy != null)
            {
                humanEnemy.Health -= dmg;
                return humanEnemy.Health;
            }

            if (wizardEnemy != null)
            {
                wizardEnemy.Health -= dmg;
                return wizardEnemy.Health;
            }

            if (ninjaEnemy != null)
            {
                ninjaEnemy.Health -= dmg;
                return ninjaEnemy.Health;
            }

            if (samuraiEnemy != null)
            {
                samuraiEnemy.Health -= dmg;
                return samuraiEnemy.Health;
            }

            return 0;
        } 
    }
}
