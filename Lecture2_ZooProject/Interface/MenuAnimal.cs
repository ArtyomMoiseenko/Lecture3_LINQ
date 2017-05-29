using System;
using Data;

namespace Lecture3_ZooProject
{
    class MenuAnimal : ICommand
    {
        public void Execute(Zoo zoo)
        {
            Console.Clear();
            Console.WriteLine("Действия:");
            Console.WriteLine("1 - Добавить животное");
            Console.WriteLine("2 - Кормить животное");
            Console.WriteLine("3 - Лечить животное");
            Console.WriteLine("4 - Удалить животное");
            Console.WriteLine("5 - Запустить таймер");
            Console.WriteLine("Дополнительные функции выборки данных зоопарка:");
            Console.WriteLine("6 - Показать всех животных, сгруппированных по виду животного");
            Console.WriteLine("7 - Показать животных по состоянию");
            Console.WriteLine("8 - Показать всех тигров, которые больны");
            Console.WriteLine("9 - Показать слона с определенной кличкой");
            Console.WriteLine("10 - Показать список всех кличек животных, которые голодны");
            Console.WriteLine("11 - Показать самых здоровых животных каждого вида (по одному на каждый вид)");
            Console.WriteLine("12 - Показать количество мертвых животных каждого вида");
            Console.WriteLine("13 - Показать всех волков и медведей, у которых здоровье выше 3");
            Console.WriteLine("14 - Показать животное с максимальным здоровьем и животное с минимальным здоровьем");
            Console.WriteLine("15 - Показать средней количество здоровья у животных в зоопарке");
            SelectMenuItem select = new SelectMenuItem();
            select.Execute(zoo);
        }
    }
}
