using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Sick : AnimalState
    {
        public override void ChangeState(Animal animal)
        {
            if (animal.CurrentHealth > 0)
            {
                animal.CurrentHealth--;
            }
            if (animal.CurrentHealth == 0)
            {
                animal.State = new Dead();
            }
        }

        public override void Heal(Animal animal)
        {
            base.Heal(animal);
            animal.State = new Hungry();
        }
        public override string ToString()
        {
            return "Болен";
        }
    }
}
