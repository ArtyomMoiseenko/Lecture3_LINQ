using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;
using System.Threading.Tasks;

namespace Lecture3_ZooProject
{
    class HealAnimal : ICommand
    {
        public void Execute(Zoo zoo)
        {
            Console.Clear();
            Console.WriteLine("Лечение животного");
            Animal animal = null;
            while (animal == null)
            {
                Console.WriteLine("Введите имя животного:");
                string name = Console.ReadLine();
                animal = zoo.ListAliveAnimals.FirstOrDefault(x => x.Name == name && !(x.State.Equals(AnimalState.Full)));
                if(animal == null)
                {
                    Console.WriteLine("Животное с данным именем отсутствует или животное - здоровое. Хотите продолжить лечение? 1 - Да, 2 - Нет");
                    if (Console.ReadLine() != "1")
                    {
                        break;
                    }
                }
                else
                {
                    animal.Heal();
                    Console.Write("Животное вылечено!");
                    break;
                }
            }
            Console.Write("\nВведите любой символ для продолжения: ");
            if (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                new MenuAnimal().Execute(zoo);
            }
        }
    }
}
