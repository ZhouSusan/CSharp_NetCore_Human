using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Ninja : Human
    {

        public Ninja(string name) : base(name) {
            this.Dexterity = 175;
        }

        public int steal(Object obj)
        {
            base.Attack(obj);
            return this.Health + 10;
        }

        public int get_away()
        {
            return this.Health -= 15;
        }
    }
}
