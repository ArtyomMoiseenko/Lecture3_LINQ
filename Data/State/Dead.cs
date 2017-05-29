using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Dead : AnimalState
    {
        public override void ChangeState(Animal animal)
        {
            animal.State = new Dead();
        }

        public override string ToString()
        {
            return "Мёртв";
        }
    }
}
