using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public abstract class Animal
    {
        public int Health { get; set; }
        public int CurrentHealth { get; set; }
        public ZooKindAnimal Kind { get; set; }
        public AnimalState State { get; set; }
        public string Name { get; set; }

        public Animal(string name)
        {
            State = new Full();
            Name = name;
        }
        public void Heal()
        {
            this.State.Heal(this);
        }
        public void Feed()
        {
            this.State.Feed(this);
        }
        public void ChangeState()
        {
            this.State.ChangeState(this);
        }
    }
}
