using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3_ZooProject
{
    class ShowCountDeadAnimalEachKind : ICommand
    {
        public void Execute(Zoo zoo)
        {
            IChooseDataAnimal selectData = zoo.ChooseDataAnimal;
            var data = selectData.ShowCountDeadAnimalEachKind();

            if (data.Count != 0)
            {
                Console.WriteLine("\nКоличество мертвых животных каждого вида:");
                foreach (var item in data)
                {
                    Console.WriteLine($"Вид = {item.Key}, Количество мёртвых животных = {item.Value}");
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
