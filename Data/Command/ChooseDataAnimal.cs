using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class ChooseDataAnimal : IChooseDataAnimal
    {
        private Zoo _zoo;

        public ChooseDataAnimal(Zoo zoo)
        {
            _zoo = zoo;
        }

        public IEnumerable<Animal> GroupByKindAnimal()
        {
            var result = _zoo.ListAllAnimals?.GroupBy(x => x.Kind, x => x).SelectMany(x => x);
            return result;
        }

        public IEnumerable<Animal> ShowByStateAnimal(AnimalState state)
        {
            var result = _zoo.ListAllAnimals?.Where(x => x.State.Equals(state));
            return result;
        }

        public IEnumerable<Animal> ShowSickTigers()
        {
            var result = _zoo.ListAllAnimals?.Where(x => x.State.Equals(AnimalState.Sick) && x.Kind == ZooKindAnimal.Tiger);
            return result;
        }

        public Animal ShowElephant(string name)
        {
            var result = _zoo.ListAllAnimals.FirstOrDefault(x => x.Name == name && x.Kind == ZooKindAnimal.Elephant);
            return result;
        }

        public IEnumerable<string> ShowListHungryAnimals()
        {
            var result = _zoo.ListAllAnimals?.Where(x => x.State.Equals(AnimalState.Hungry)).Select(x => x.Name);
            return result;
        }
        
        public IEnumerable<Animal> ShowHealthyAnimalsByKind()
        {
            var result = _zoo.ListAllAnimals?
                .GroupBy(x => x.Kind)
                .Select(item => item.FirstOrDefault(p => p.CurrentHealth == item.Max(x => x.CurrentHealth)));
            return result;
        }

        public Dictionary<ZooKindAnimal, int> ShowCountDeadAnimalEachKind()
        {
            var result = _zoo.ListAllAnimals?
                .GroupBy(x => x.Kind)
                .ToDictionary(item => item.Key, item => item.Count(p => p.State.Equals(AnimalState.Dead)));
            return result;
        }

        public IEnumerable<Animal> ShowWolfsBearsHealthMoreThree()
        {
            var result = _zoo.ListAllAnimals?.Where(x => (x.Kind == ZooKindAnimal.Wolf || x.Kind == ZooKindAnimal.Bear) && x.CurrentHealth > 3);
            return result;
        }
        
        public Tuple<Animal, Animal> ShowAnimalsMaxHealthMinHealth()
        {
            var result = Tuple.Create(
                                _zoo.ListAllAnimals?
                                    .FirstOrDefault(p => p.CurrentHealth == _zoo.ListAllAnimals.Max(x => x.CurrentHealth)),
                                _zoo.ListAllAnimals?
                                    .FirstOrDefault(p => p.CurrentHealth == _zoo.ListAllAnimals.Min(x => x.CurrentHealth))
                        );
            return result;
        }

        public Nullable<double> ShowAvgHealthAnimals()
        {
            double? result = null;
            if (_zoo.ListAllAnimals.Count() != 0)
            {
                result = _zoo.ListAllAnimals.Average(x => x.CurrentHealth);
            }
            return result;
        }
    }
}
