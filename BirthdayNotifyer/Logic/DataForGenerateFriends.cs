using System;
using System.Collections.Generic;

namespace BirthdayNotifyer
{
    class DataForGenerateFriends
    {
        List<string> firstNames = new List<string>() 
        { 
            "Иван", "Дмитрий", "Александр", "Фёдор", "Алексей", "Илья", "Сергей", "Семён", "Арсений",
            "Богдан", "Иосиф", "Давид", "Даниил", "Виктор", "Вадим", "Артём", "Константин", "Борис"
        };

        List<string> secondNames = new List<string>()
        {
            "Иванов", "Воронов", "Довыдов", "Петров", "Сизов", "Солнцев", "Седой", "Павлов", "Рязанцев",
            "Борзов", "Фефелов", "Игнатов", "Сапогов", "Белкин", "Волков", "Пустой", "Узоров", "Зайцев"
        };

        List<string> fatherNames = new List<string>()
        {
            "Иванович", "Дмитриевич", "Александрович", "Фёдорович", "Алексеевич", "Ильич", "Сергеевич", "Семёнович", "Арсениевич",
            "Богданович", "Иосифофич", "Давидович", "Даниилович", "Викторович", "Вадимович", "Артёмович", "Константинович", "Борисович"
        };

        /// <summary>
        /// Генерирует случайное ФИО по заданным в программе именам, фамилиям, отчествам
        /// </summary>
        /// <returns></returns>
        public string GetRandomName()
        {
            Random random = new Random();
            string name = string.Empty;

            name += firstNames[random.Next(firstNames.Count)] + " ";
            name += secondNames[random.Next(firstNames.Count)] + " ";
            name += fatherNames[random.Next(firstNames.Count)];

            return name;
        }

        /// <summary>
        /// Генерирует случайную дату рождения для совершеннолетнего в указанном диапазоне.
        /// </summary>
        /// <param name="range">Диапазон отклонение даты</param>
        /// <returns>Возвращает строковое значение даты в формате дд.ммм.гггг</returns>
        public DateTime GetRandomBirthdate(int range)
        {
            Random random = new Random();

            int daysForFirst18 = 18 * 365;

            return DateTime.Now.AddDays(-daysForFirst18).AddDays(-random.Next(range));
        }
    }
}
