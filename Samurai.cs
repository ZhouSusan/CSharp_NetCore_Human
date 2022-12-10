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
         
            if (humanTarget != null)
            {
                if (humanTarget.Health < 50)
                {
                    humanTarget.Health = 0;
                }
                return humanTarget.Health;
            }

          
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
