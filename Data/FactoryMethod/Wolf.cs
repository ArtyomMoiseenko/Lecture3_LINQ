using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class Wolf : Animal
    {
        public Wolf(string name)
            : base(name)
        {
            Health = 4;
            CurrentHealth = Health;
            Kind = ZooKindAnimal.Wolf;
        }

        public override string ToString()
        {
            return "Волк";
        }
    }
}
