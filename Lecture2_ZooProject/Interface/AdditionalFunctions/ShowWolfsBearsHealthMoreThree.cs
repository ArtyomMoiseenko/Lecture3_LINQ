using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3_ZooProject
{
    class ShowWolfsBearsHealthMoreThree : ICommand
    {
        public void Execute(Zoo zoo)
        {
            IChooseDataAnimal selectData = zoo.ChooseDataAnimal;
            var data = selectData.ShowWolfsBearsHealthMoreThree();

            if (data.FirstOrDefault() != null)
            {
                Console.WriteLine("\nВолки и медведи, имеющие здоровья более 3:");
                foreach (var item in data)
                {
                    Console.WriteLine($"Вид = {item.Kind}, Жизни = {item.CurrentHealth}: Имя = {item.Name}| Состояние = {item.State}");
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
