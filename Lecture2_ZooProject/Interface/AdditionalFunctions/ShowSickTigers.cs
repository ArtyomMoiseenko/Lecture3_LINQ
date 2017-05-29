using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Lecture3_ZooProject
{
    class ShowSickTigers : ICommand
    {
        public void Execute(Zoo zoo)
        {
            IChooseDataAnimal selectData = zoo.ChooseDataAnimal;
            var data = selectData.ShowSickTigers();

            if (data.FirstOrDefault() != null)
            {
                Console.WriteLine("\nВсе тигры, которые имеют состояние 'Болен':");
                foreach (var item in data)
                {
                    Console.WriteLine($"Вид = {item.Kind}, Состояние = {item.State}: Имя = {item.Name}| Жизни = {item.CurrentHealth}");
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
