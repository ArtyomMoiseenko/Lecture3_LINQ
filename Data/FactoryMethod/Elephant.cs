using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class Elephant : Animal
    {
        public Elephant(string name)
            : base(name)
        {
            Health = 7;
            CurrentHealth = Health;
            Kind = ZooKindAnimal.Elephant;
        }

        public override string ToString()
        {
            return "Слон";
        }
    }
}
