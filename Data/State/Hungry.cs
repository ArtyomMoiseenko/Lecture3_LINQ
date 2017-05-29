using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Hungry : AnimalState
    {
        public override void ChangeState(Animal animal)
        {
            animal.State = new Sick();
        }
        public override void Feed(Animal animal)
        {
            animal.State = new Full();
        }
        public override string ToString()
        {
            return "Голоден";
        }
    }
}
