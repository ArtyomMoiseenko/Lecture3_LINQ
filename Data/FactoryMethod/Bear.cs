using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class Bear : Animal
    {
        public Bear(string name)
            : base(name)
        {
            Health = 6;
            CurrentHealth = Health;
            Kind = ZooKindAnimal.Bear;
        }

        public override string ToString()
        {
            return "Медведь";
        }
    }
}
