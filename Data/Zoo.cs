using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Zoo
    {
        public List<Animal> ListAliveAnimals { get; set; } = new List<Animal>();
        public List<Animal> ListDeadAnimals { get; set; } = new List<Animal>();
        public IEnumerable<Animal> ListAllAnimals
        {
            get
            {
                return ListAliveAnimals.Union<Animal>(ListDeadAnimals).ToList();
            }
        }
        public IChooseDataAnimal ChooseDataAnimal { get; }

        public Zoo()
        {
            ChooseDataAnimal = new ChooseDataAnimal(this);
        }
    }


    public enum ZooKindAnimal
    {
        Bear,
        Elephant,
        Fox,
        Lion,
        Tiger,
        Wolf
    }
}
