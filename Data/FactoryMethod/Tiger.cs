using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class Tiger : Animal
    {
        public Tiger(string name)
            : base(name)
        {
            Health = 4;
            CurrentHealth = Health;
            Kind = ZooKindAnimal.Tiger;
        }

        public override string ToString()
        {
            return "Тигр";
        }
    }
}
