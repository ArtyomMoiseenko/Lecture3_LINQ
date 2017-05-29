using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class Lion : Animal
    {
        public Lion(string name)
            : base(name)
        {
            Health = 5;
            CurrentHealth = Health;
            Kind = ZooKindAnimal.Lion;
        }

        public override string ToString()
        {
            return "Лев";
        }
    }
}
