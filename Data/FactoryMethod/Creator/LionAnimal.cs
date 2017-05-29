using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class LionAnimal : IAnimalCreator
    {
        public Animal Create(string name)
        {
            return new Lion(name);
        }
    }
}
