using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class Fox : Animal
    {
        public Fox(string name)
            : base(name)
        {
            Health = 3;
            CurrentHealth = Health;
            Kind = ZooKindAnimal.Fox;
        }

        public override string ToString()
        {
            return "Лис";
        }
    }
}
