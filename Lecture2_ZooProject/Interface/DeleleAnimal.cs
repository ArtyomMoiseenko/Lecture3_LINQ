using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3_ZooProject
{
    class DeleleAnimal : ICommand
    {
        public void Execute(Zoo zoo)
        {
            Console.Clear();
            Console.WriteLine("Удаление животного");
            Animal animal = null;
            while (animal == null)
            {
                Console.WriteLine("Введите имя животного:");
                string name = Console.ReadLine();
                animal = zoo.ListDeadAnimals.FirstOrDefault(x => x.Name == name && x.State.Equals(AnimalState.Dead));
                if (animal == null)
                {
                    Console.WriteLine("Животное с данным именем отсутствует или животное не мертво. Хотите продолжить удаление? 1 - Да, 2 - Нет");
                    if (Console.ReadLine() != "1")
                    {
                        break;
                    }
                }
                else
                {
                    zoo.ListDeadAnimals.Remove(animal);
                    Console.Write("Животное удалено!");
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
