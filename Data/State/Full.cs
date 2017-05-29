using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Full : AnimalState
    {
        public override void ChangeState(Animal animal)
        {
            animal.State = new Hungry();
        }

        public override string ToString()
        {
            return "Сытый";
        }
    }
}
