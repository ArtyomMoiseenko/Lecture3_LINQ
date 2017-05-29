using System;
using System.Linq;
using Data;
using System.Threading;

namespace Lecture3_ZooProject
{
    class ShowAnimal : ICommand
    {
        private bool _keyPress = false;

        private void KeyPress()
        {
            if (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                _keyPress = true;
            }
        }

        public void Execute(Zoo zoo)
        {
            Thread thread = new Thread(KeyPress);
            Random random = new Random();
            int time = 0;
            thread.Start();
            while (zoo.ListAliveAnimals.Count > 0)
            {
                if (_keyPress)
                {
                    thread.Abort();
                    break;
                }
                if (time == 1)
                {
                    zoo.ListAliveAnimals[random.Next(0, zoo.ListAliveAnimals.Count)]?.ChangeState();
                    zoo.ListDeadAnimals.AddRange(zoo.ListAliveAnimals.Where(item => item.State.Equals(AnimalState.Dead)));
                    zoo.ListAliveAnimals.RemoveAll(item => item.State.Equals(AnimalState.Dead));
                    time = 0;
                }
                Console.Clear();
                Console.Write("Имя");
                Console.SetCursorPosition(25, 0);
                Console.Write("Вид");
                Console.SetCursorPosition(50, 0);
                Console.Write("Состояние");
                Console.SetCursorPosition(75, 0);
                Console.WriteLine("Здоровье");
                int size = 1;
                foreach (var item in zoo.ListAliveAnimals)
                {
                    Console.Write(item.Name);
                    Console.SetCursorPosition(25, size);
                    Console.Write(item);
                    Console.SetCursorPosition(50, size);
                    Console.Write(item.State);
                    Console.SetCursorPosition(75, size);
                    Console.WriteLine(item.CurrentHealth);
                    size++;
                }
                Console.SetCursorPosition(0, size);
                size++;
                Console.WriteLine(DateTimeOffset.Now.ToString("T"));
                Console.SetCursorPosition(0, size);
                size++;
                Console.WriteLine("\nСписок мёртвых животных");
                Console.SetCursorPosition(0, size);
                size++;
                foreach (var item in zoo.ListDeadAnimals)
                {
                    Console.SetCursorPosition(0, size);
                    Console.Write(item.Name);
                    Console.SetCursorPosition(25, size);
                    Console.Write(item);
                    Console.SetCursorPosition(50, size);
                    Console.Write(item.State);
                    Console.SetCursorPosition(75, size);
                    Console.WriteLine(item.CurrentHealth);
                    size++;
                }
                Console.SetCursorPosition(0, size);
                Console.Write("Введите любой символ для выхода: ");
                time++;
                Thread.Sleep(1000);
            }
            if(zoo.ListAliveAnimals.Count == 0)
            {
                Console.Clear();
                Console.Write("Все животные мертвы!");
                Console.Write("\nВведите любой символ для продолжения: ");
                if (Console.ReadKey().Key != ConsoleKey.Enter)
                {
                    new MenuAnimal().Execute(zoo);
                }
            }
            else
            {
                new MenuAnimal().Execute(zoo);
            }
        }
    }
}
