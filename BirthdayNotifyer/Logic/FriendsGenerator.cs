using System;
using System.Collections.Generic;

namespace BirthdayNotifyer
{
    class FriendsGenerator
    {
        static Random randomizer = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);

        static List<string> firstNames = new List<string>() 
        { 
            "Иван", "Дмитрий", "Александр", "Фёдор", "Алексей", "Илья", "Сергей", "Семён", "Арсений",
            "Богдан", "Иосиф", "Давид", "Даниил", "Виктор", "Вадим", "Артём", "Константин", "Борис"
        };

        static List<string> secondNames = new List<string>()
        {
            "Иванов", "Воронов", "Довыдов", "Петров", "Сизов", "Солнцев", "Седой", "Павлов", "Рязанцев",
            "Борзов", "Фефелов", "Игнатов", "Сапогов", "Белкин", "Волков", "Пустой", "Узоров", "Зайцев"
        };

        static List<string> fatherNames = new List<string>()
        {
            "Иванович", "Дмитриевич", "Александрович", "Фёдорович", "Алексеевич", "Ильич", "Сергеевич", "Семёнович", "Арсениевич",
            "Богданович", "Иосифофич", "Давидович", "Даниилович", "Викторович", "Вадимович", "Артёмович", "Константинович", "Борисович"
        };

        /// <summary>
        /// Генерирует случайное ФИО по заданным в программе именам, фамилиям, отчествам
        /// </summary>
        /// <returns></returns>
        public static string GetRandomName()
        {
            string name = string.Empty;

            name += secondNames[randomizer.Next(firstNames.Count)] + " ";
            name += firstNames[randomizer.Next(firstNames.Count)] + " ";
            name += fatherNames[randomizer.Next(firstNames.Count)];

            return name;
        }

        /// <summary>
        /// Генерирует случайную дату рождения для совершеннолетнего в указанном диапазоне.
        /// </summary>
        /// <param name="range">Диапазон отклонение даты</param>
        /// <returns>Возвращает строковое значение даты в формате дд.ммм.гггг</returns>
        public static DateTime GetRandomBirthdate(int range)
        {
            DateTime retDate = DateTime.Today.AddYears(-18).AddDays(-randomizer.Next(range));

            if (retDate.Month == 2 && retDate.Day == 29)
                retDate.AddDays(-1);
            
            return retDate;
        }
    }
}
