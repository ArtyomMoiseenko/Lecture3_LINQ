using System;
using System.Collections.Generic;
using Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3_ZooProject
{
    class CreateAnimal : ICommand
    {
        private List<string> _stringAnimals = new List<string>() { "Медведь", "Слон", "Лис", "Лев", "Тигр", "Волк" };

        public void Execute(Zoo zoo)
        {
            Console.Clear();
            Console.WriteLine("Добавление животного");
            for (int i = 0; i < _stringAnimals.Count; i++)
            {
                Console.WriteLine("{0} - {1}", i + 1, _stringAnimals[i]);
            }
            IAnimalCreator animal = null;
            Console.WriteLine("Выберите тип животного:");
            while (animal == null)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        animal = new BearAnimal();
                        break;
                    case "2":
                        animal = new ElephantAnimal();
                        break;
                    case "3":
                        animal = new FoxAnimal();
                        break;
                    case "4":
                        animal = new LionAnimal();
                        break;
                    case "5":
                        animal = new TigerAnimal();
                        break;
                    case "6":
                        animal = new WolfAnimal();
                        break;
                    default:
                        Console.WriteLine("Попробуйте снова!");
                        break;
                }
            }
            Console.Write("Введите имя животного: ");
            string name = Console.ReadLine();
            zoo.ListAliveAnimals.Add(animal.Create(name));
            Console.Write("Животное добавлено!");
            Console.Write("\nВведите любой символ для продолжения: ");
            if (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                new MenuAnimal().Execute(zoo);
            }
        }
    }
}
