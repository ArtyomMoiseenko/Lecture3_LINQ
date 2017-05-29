using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3_ZooProject
{
    class ShowByStateAnimal : ICommand
    {
        public void Execute(Zoo zoo)
        {
            AnimalState state = null;
            Console.WriteLine($"\nВыберите состояние животного:");
            Console.WriteLine($"1 - Сыт");
            Console.WriteLine($"2 - Голоден");
            Console.WriteLine($"3 - Болен");
            Console.WriteLine($"4 - Мёртв");
            do
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        state = AnimalState.Full;
                        break;
                    case "2":
                        state = AnimalState.Hungry;
                        break;
                    case "3":
                        state = AnimalState.Sick;
                        break;
                    case "4":
                        state = AnimalState.Dead;
                        break;
                    default:
                        Console.WriteLine("Попробуйте снова!");
                        break;
                }
            } while (state == null);

            IChooseDataAnimal selectData = zoo.ChooseDataAnimal;
            var data = selectData.ShowByStateAnimal(state);

            if(data.FirstOrDefault() != null)
            {
                Console.WriteLine($"\nВсе животные, имеющие состояние '{state}':");
                foreach (var item in data)
                {
                    Console.WriteLine($"Состояние = {item.State}: Имя = {item.Name}| Вид = {item.Kind}| Жизни = {item.CurrentHealth}");
                }
            }
            else
            {
                Console.WriteLine($"\nЖиивотные, имеющие состояние '{state}' отсутствуют");
            }

            Console.Write("\nВведите любой символ для продолжения: ");
            if (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                new MenuAnimal().Execute(zoo);
            }
        }
    }
}
