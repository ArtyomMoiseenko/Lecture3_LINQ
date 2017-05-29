using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Lecture3_ZooProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();
            DataSource data = new DataSource();
            zoo.ListAliveAnimals = data.GetAnimals();

            ICommand start = new MenuAnimal();
            start.Execute(zoo);
        }
    }
}
