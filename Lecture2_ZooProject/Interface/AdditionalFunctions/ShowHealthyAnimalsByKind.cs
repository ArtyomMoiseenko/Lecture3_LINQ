using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3_ZooProject
{
    class ShowHealthyAnimalsByKind : ICommand
    {
        public void Execute(Zoo zoo)
        {
            IChooseDataAnimal selectData = zoo.ChooseDataAnimal;
            var data = selectData.ShowHealthyAnimalsByKind();

            if (data.FirstOrDefault() != null)
            {
                Console.WriteLine("\nВсе животные, которые имеют состояние здоровы:");
                foreach (var item in data)
                {
                    Console.WriteLine($"Вид = {item.Kind}: Имя = {item.Name}| Состояние = {item.State}| Жизни = {item.CurrentHealth}");
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
