using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3_ZooProject
{
    class ShowListHungryAnimals : ICommand
    {
        public void Execute(Zoo zoo)
        {
            IChooseDataAnimal selectData = zoo.ChooseDataAnimal;
            var data = selectData.ShowListHungryAnimals();

            if (data.FirstOrDefault() != null)
            {
                Console.WriteLine("\nВсе животные, которые имеют состояние 'Голоден':");
                foreach (var item in data)
                {
                    Console.WriteLine($"|{item}|");
                }
            }
            else
            {
                Console.WriteLine($"\nЖивотные отсутствуют");
            }

            Console.Write("\nВведите любой символ для продолжения: ");
            if (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                new MenuAnimal().Execute(zoo);
            }
        }
    }
}
