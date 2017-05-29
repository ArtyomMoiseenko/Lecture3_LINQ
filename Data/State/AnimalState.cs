using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public abstract class AnimalState
    {
        public static Full Full { get { return new Full();  } }
        public static Hungry Hungry { get { return new Hungry();  } }
        public static Sick Sick { get { return new Sick();  } }
        public static Dead Dead { get { return new Dead();  } }


        public abstract void ChangeState(Animal animal);

        public virtual void Feed(Animal animal) { }

        public virtual void Heal(Animal animal)
        {
            if (animal.CurrentHealth < animal.Health && animal.CurrentHealth > 0)
            {
                animal.CurrentHealth++;
            }
        }

        public override bool Equals(object obj)
        {
            return this.ToString().Equals(obj.ToString());
        }
    }
}
