using System;
using System.Collections.Generic;

namespace Data
{
    public interface IChooseDataAnimal
    {
        IEnumerable<Animal> GroupByKindAnimal();

        IEnumerable<Animal> ShowByStateAnimal(AnimalState state);

        IEnumerable<Animal> ShowSickTigers();

        Animal ShowElephant(string name);

        IEnumerable<string> ShowListHungryAnimals();

        IEnumerable<Animal> ShowHealthyAnimalsByKind();

        Dictionary<ZooKindAnimal, int> ShowCountDeadAnimalEachKind();

        IEnumerable<Animal> ShowWolfsBearsHealthMoreThree();

        Tuple<Animal, Animal> ShowAnimalsMaxHealthMinHealth();

        Nullable<double> ShowAvgHealthAnimals();
    }
}
