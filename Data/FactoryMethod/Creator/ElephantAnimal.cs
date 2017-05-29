using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ElephantAnimal : IAnimalCreator
    {
        public Animal Create(string name)
        {
            return new Elephant(name);
        }
    }
}
