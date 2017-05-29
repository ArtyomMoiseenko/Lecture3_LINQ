using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3_ZooProject
{
    interface ICommand
    {
        void Execute(Zoo zoo);
    }
}
