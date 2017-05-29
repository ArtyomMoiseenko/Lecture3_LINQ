using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3_ZooProject
{
    class FeedAnimal : ICommand
    {
        public void Execute(Zoo zoo)
        {
            Console.Clear();
            Console.WriteLine("Покормить животное");
            Animal animal = null;
            while (animal == null)
            {
                Console.WriteLine("Введите имя животного:");
                string name = Console.ReadLine();
                animal = zoo.ListAliveAnimals.FirstOrDefault(x => x.Name == name && !(x.State.Equals(AnimalState.Sick)));
                if (animal == null)
                {
                    Console.WriteLine("Животное с данным именем отсутствует или животное имеет состояние 'Болен'. Хотите продолжить кормление? 1 - Да, 2 - Нет");
                    if (Console.ReadLine() != "1")
                    {
                        break;
                    }
                }
                else
                {
                    animal.Feed();
                    Console.Write("Животное покормлено!");
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
