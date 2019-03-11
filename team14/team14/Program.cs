using System;
using System.Collections.Generic;

namespace team14
{

    struct Filter
    {
        #region Поля фильтра

        public string Surname;                     // Фамилия
        public string Position;                    // Должность

        public DateTime? ContractSigningDateMin;   // Дата подписания контракта (min)
        public DateTime? ContractSigningDateMax;   // Дата подписания контракта (max)

        public uint? ContractTermMin;              // Срок действия контракта (min)
        public uint? ContractTermMax;              // Срок действия контракта (max)

        public uint? SalaryMin;                    // Срок действия контракта (min)
        public uint? SalaryMax;                    // Срок действия контракта (max)

        #endregion

        #region Методы для ввода полей фильтра с клавиатуры 
        public void Input()
        {
            Console.WriteLine("Введите значение филтра поля \"Фамилия\":");
            Surname = Console.ReadLine();

            Console.WriteLine("Введите значение филтра поля \"Позиция\":");
            Surname = Console.ReadLine();

            Console.WriteLine("Введите значение верхней страницы диапазона фильтра поля \"Дата подписания договора\"");
            ContractSigningDateMax = InputDateTime();

            Console.WriteLine("Введите значение верхней страницы диапазона фильтра поля \"Дата подписания договора\"");
            ContractSigningDateMin = InputDateTime();

            Console.WriteLine("Введите значение нижней границы диапазона фильтра поля \"Срок дейстрвия контракта\"");
            ContractTermMin = InputUint();

            Console.WriteLine("Введите значение верхней границы диапазона фильтра поля \"Срок дейстрвия контракта\"");
            ContractTermMax = InputUint();

            Console.WriteLine("Введите значение нижней границы диапазона фильтра поля \"Оклад\"");
            SalaryMin = InputUint();

            Console.WriteLine("Введите значение верхней границы диапазона фильтра поля \"Оклад\"");
            SalaryMin = InputUint();
        }
        #endregion

        #region Приватные методы
        private DateTime? InputDateTime()
        {
            /*
            Прочитать строку с клавиатуры
            if введеная строка не пуста {
                Преобразуем строку в дату
                if преобразование успешно {
                    вернуть дату
                }
                else {
                    Вывести сообщение об ошибке
                }
            }
            вернуть NULL
            */

            // Прочитать строку с клавиатуры
            string temp = Console.ReadLine();
            // if введеная строка не пуста
            if (temp != String.Empty)
            {
                try
                {
                    // Преобразуем строку в дату
                    var result = DateTime.Parse(temp);
                    //  if преобразование успешно {
                    //      вернуть дату
                    //  }
                    return result;
                }
                catch (Exception e)
                {   
                    //  else {
                    //      Вывести значение об ошибке
                    //  }
                    Console.WriteLine("Некорректный ввод! Повторите операцию.");
                }
            }
            return null;
        }

        private uint? InputUint()
        {
            /*
            Прочитать строку с клавиатуры
            if введеная строка не пуста {
                Преобразуем строку в число
                if преобразование успешно {
                    вернуть число
                }
                else {
                    Вывести сообщение об ошибке
                }
            }
            вернуть NULL
            */

            string temp = Console.ReadLine();
            // if введеная строка не пуста
            if (temp != String.Empty)
            {
                try
                {
                    // Преобразуем строку в дату
                    var result = UInt32.Parse(temp);
                    //  if преобразование успешно {
                    //      вернуть число
                    //  }
                    return result;
                }
                catch (Exception e)
                {
                    //  else {
                    //      Вывести значение об ошибке
                    //  }
                    Console.WriteLine("Некорректный ввод! Повторите операцию.");
                }
            }
            return null;
        }
        #endregion
    }

    struct Worker
    {
        #region Свойства

        /// <summary>
        /// Фамилия работника
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Должность
        /// </summary>
        public string Position { get; set; }
        /// <summary>
        /// Дата подписания контракта
        /// </summary>
        public DateTime ContractSigningDate { get; set; }
        /// <summary>
        /// Срок действия контракта
        /// </summary>
        public uint ContractTerm { get; set; }
        /// <summary>
        /// Оклад
        /// </summary>
        public uint Salary { get; set; }

        /// <summary>
        /// Фильтр
        /// </summary>
        public static Filter Filter { get; set; }

        #endregion


        /// <summary>
        /// Ввод информации о работнике с клавиатуры
        /// </summary>
        /// <param name="list">Список работников</param>
        public static void AddNewWorker(IList<Worker> list)
        {
            Worker worker = new Worker();
            Console.Write("Введите фамилию работника:  ");
            worker.Surname = Console.ReadLine();
            Console.Write("Введите должность работника:  ");
            worker.Position = Console.ReadLine();
            Console.Write("Введите дату подписания контракта в формате (DD.MM.YYYY):  ");
            worker.ContractSigningDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Введите срок действия контракта:  ");
            worker.ContractTerm = Convert.ToUInt32(Console.ReadLine());
            Console.Write("Введите оклад работника:  ");
            worker.Salary = Convert.ToUInt32(Console.ReadLine());
            list.Add(worker);
        }

        /// <summary>
        /// Вывод информации о работнике на экран
        /// </summary>
        public void PrintWorker()
        {
            Console.WriteLine($"Фамилия: {Surname}");
            Console.WriteLine($"Должность: {Position}");
            Console.WriteLine($"Дата подписания контракта: {ContractSigningDate.ToString("dd.MM.yyyy")}");
            Console.WriteLine($"Срок контракта: {ContractTerm}");
            Console.WriteLine($"Оклад: {Salary}");
        }

        /// <summary>
        /// Вывод всех работников на экран
        /// </summary>
        /// <param name="list">Список работников</param>
        public static void PrintAllWorkers(IList<Worker> list)
        {
            int count = 0;
            foreach (var el in list)
            {
                Console.WriteLine($"{++count}-й работник:");
                el.PrintWorker();
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Вывод работников, удовлетворяющих фильтру
        /// </summary>
        /// <param name="list">Список работников</param>
        public static void PrintFilteredWokers(IList<Worker> list)
        {

        }

        /// <summary>
        /// Проверка, удовлетворяет ли работник условиям фильтра
        /// </summary>
        public bool CheckWithFilter()
        {
            // Проверка поля "Оклад"
            if ((Filter.SalaryMax != null) && (this.Salary > Filter.SalaryMax))
                return false;
            if ((Filter.SalaryMin != null) && (this.Salary < Filter.SalaryMin))
                return false;

            // Проверка поля "Срок действия контракта"
            if ((Filter.ContractTermMax != null) && (this.ContractTerm > Filter.ContractTermMax))
                return false;
            if ((Filter.ContractTermMin != null) && (this.ContractTerm < Filter.ContractTermMin))
                return false;

            // Проверка поля "Дата подписания котракта"
            if ((Filter.ContractSigningDateMax != null) && (this.ContractSigningDate > Filter.ContractSigningDateMax))
                return false;
            if ((Filter.ContractSigningDateMin != null) && (this.ContractSigningDate < Filter.ContractSigningDateMin))
                return false;

            // Проверка поля "Должность"
            if ((Filter.Position != null) && (!this.Position.Contains(Filter.Position)))
                return false;

            // Проверка поля "Фамилия"
            if ((Filter.Surname != null) && (!this.Surname.Contains(Filter.Surname)))
                return false;

            // Все поля прошли проверку
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}