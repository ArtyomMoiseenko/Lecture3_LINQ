using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DataSource
    {
        public List<Animal> GetAnimals()
        {
            var animals = new List<Animal>
            {
                new BearAnimal().Create("Василий"),
                new BearAnimal().Create("Пётр"),
                new BearAnimal().Create("Константин"),
                new BearAnimal().Create("Бурчик"),

                new ElephantAnimal().Create("Мамонт"),
                new ElephantAnimal().Create("Пушок"),
                new ElephantAnimal().Create("Годзилла"),
                new ElephantAnimal().Create("Соня"),

                new FoxAnimal().Create("Хитрюга"),
                new FoxAnimal().Create("Рыжий"),
                new FoxAnimal().Create("Пушистик"),
                new FoxAnimal().Create("Шустрик"),

                new LionAnimal().Create("Симба"),
                new LionAnimal().Create("Скар"),
                new LionAnimal().Create("Огонёк"),
                new LionAnimal().Create("Алекс"),

                new TigerAnimal().Create("Саблезуб"),
                new TigerAnimal().Create("Остроклык"),
                new TigerAnimal().Create("Полосатик"),
                new TigerAnimal().Create("Грознорёв"),

                new WolfAnimal().Create("Вожак"),
                new WolfAnimal().Create("Джейкоб"),
                new WolfAnimal().Create("Сэд"),
                new WolfAnimal().Create("Лия")
            };

            return animals;
        }
    }
}
