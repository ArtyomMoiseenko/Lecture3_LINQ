using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class WolfAnimal : IAnimalCreator
    {
        public Animal Create(string name)
        {
            return new Wolf(name);
        }
    }
}
