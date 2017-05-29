using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Lecture3_ZooProject
{
    class GroupByKindAnimal : ICommand
    {
        public void Execute(Zoo zoo)
        {
            IChooseDataAnimal selectData = zoo.ChooseDataAnimal;
            var data = selectData.GroupByKindAnimal();

            if (data.FirstOrDefault() != null)
            {
                Console.WriteLine("\nВсе животные, сгруппированные по виду животного:");
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
