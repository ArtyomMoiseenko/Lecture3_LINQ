using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3_ZooProject
{
    class ShowAnimalsMaxHealthMinHealth : ICommand
    {
        public void Execute(Zoo zoo)
        {
            IChooseDataAnimal selectData = zoo.ChooseDataAnimal;
            var data = selectData.ShowAnimalsMaxHealthMinHealth();

            if (data.Item1 != null && data.Item1 != null)
            {
                Console.WriteLine("\nЖивотные, имеющие максимальное и минимальное кол-во здоровья:");
                Console.WriteLine($"Вид = {data.Item1.Kind}, Жизни = {data.Item1.CurrentHealth}: Имя = {data.Item1.Name}| Состояние = {data.Item1.State}");
                Console.WriteLine($"Вид = {data.Item2.Kind}, Жизни = {data.Item2.CurrentHealth}: Имя = {data.Item2.Name}| Состояние = {data.Item2.State}");
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
