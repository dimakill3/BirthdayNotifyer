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
        /// Генерирует случайное ФИО по заданным в программе именам
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
        /// Генерирует случайную дату рождения относительно 01.01.2000 в заданном диапазоне
        /// </summary>
        /// <param name="range">Диапазон отклонение даты</param>
        /// <returns>Возвращает строковое значение даты в формате дд.ммм.гггг</returns>
        public string GetRandomBirthdate(int range)
        {
            Random random = new Random();

            return new DateTime(2000, 1, 1).AddDays(random.Next(-range, range + 1)).ToString("dd,MMM,yyyy");
        }
    }
}
