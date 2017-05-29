using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Lecture3_ZooProject
{
    class SelectMenuItem : ICommand
    {
        public void Execute(Zoo zoo)
        {
            ICommand command = null;
            do
            {
                Console.Write("Выберите действие: ");
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        command = new CreateAnimal();
                        command.Execute(zoo);
                        break;
                    case "2":
                        command = new FeedAnimal();
                        command.Execute(zoo);
                        break;
                    case "3":
                        command = new HealAnimal();
                        command.Execute(zoo);
                        break;
                    case "4":
                        command = new DeleleAnimal();
                        command.Execute(zoo);
                        break;
                    case "5":
                        command = new ShowAnimal();
                        command.Execute(zoo);
                        break;
                    case "6":
                        command = new GroupByKindAnimal();
                        command.Execute(zoo);
                        break;
                    case "7":
                        command = new ShowByStateAnimal();
                        command.Execute(zoo);
                        break;
                    case "8":
                        command = new ShowSickTigers();
                        command.Execute(zoo);
                        break;
                    case "9":
                        command = new ShowElephant();
                        command.Execute(zoo);
                        break;
                    case "10":
                        command = new ShowListHungryAnimals();
                        command.Execute(zoo);
                        break;
                    case "11":
                        command = new ShowHealthyAnimalsByKind();
                        command.Execute(zoo);
                        break;
                    case "12":
                        command = new ShowCountDeadAnimalEachKind();
                        command.Execute(zoo);
                        break;
                    case "13":
                        command = new ShowWolfsBearsHealthMoreThree();
                        command.Execute(zoo);
                        break;
                    case "14":
                        command = new ShowAnimalsMaxHealthMinHealth();
                        command.Execute(zoo);
                        break;
                    case "15":
                        command = new ShowAvgHealthAnimals();
                        command.Execute(zoo);
                        break;
                    default:
                        Console.WriteLine("Попробуйте снова!");
                        break;
                }
            } while (command == null);
        }
    }
}
