using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Samurai : Human
    {
        private static int count = 0;
        public static int Count
        {
            get
            {
                return count;
            }
            set {}
        }

        public Samurai(string name) : base(name)
        {
            this.Health = 200;
            Count += 1; 
        }

        public int death_blow(Object obj) 
        {
            base.Attack(obj);
            
            Human humanTarget = (Human)obj;
            //Wizard wizardTarget = (Wizard)obj;
            //Ninja ninjaTarget = (Ninja)obj;
            //Samurai samuraiTarget = (Samurai)obj;

            if (humanTarget != null)
            {
                if (humanTarget.Health < 50)
                {
                    humanTarget.Health = 0;
                }
                return humanTarget.Health;
            }

            /*if (wizardTarget != null)
            {
                if (wizardTarget.Health < 50)
                {
                    wizardTarget.Health = 0;
                }
                return wizardTarget.Health;
            }

            if (ninjaTarget != null)
            {
                if (ninjaTarget.Health < 50)
                {
                    ninjaTarget.Health = 0;
                }
                return ninjaTarget.Health;
            }

            if (samuraiTarget != null)
            {
                if (samuraiTarget.Health < 50)
                {
                    samuraiTarget.Health = 0;
                }
                return samuraiTarget.Health;
            }*/

            return 0;
        }

        public int meditiate()
        {
            return this.Health = 200;
        }

        public static void how_many()
        {
            Console.WriteLine($"There are {Samurai.Count} samurais on the battle field");
        }
    }
}
