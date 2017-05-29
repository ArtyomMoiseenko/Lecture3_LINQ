using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3_ZooProject
{
    class ShowElephant : ICommand
    {
        public void Execute(Zoo zoo)
        {
            IChooseDataAnimal selectData = zoo.ChooseDataAnimal;
            Animal data = null;
            Console.Write($"\nВведите кличку слона: ");
            while (data == null)
            {
                string name = Console.ReadLine();
                data = selectData.ShowElephant(name);
                if(data != null)
                {
                    Console.WriteLine($"\nСлон с именем {data.Name}:");
                    Console.WriteLine($"Имя = {data.Name}: Вид = {data.Kind}| Состояние = {data.State}| Жизни = {data.CurrentHealth}");
                    break;
                }
                else
                {
                    Console.WriteLine("Слон с данным именем отсутствует. Хотите продолжить поиск слона? 1 - Да, 2 - Нет");
                    if (Console.ReadLine() != "1")
                    {
                        break;
                    }
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
